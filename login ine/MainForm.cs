using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient; // Biblioteca para trabajar con MySQL
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Printing;

namespace login_ine
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static class ConexionMySQL
        {
            private static string conexionString = "Server=localhost;Port=3306;Database=ine;User Id=root;Password=21082007jd;";

            public static string ObtenerDescripcionDesdeBD(string cime)
            {
                string descripcion = string.Empty;

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(conexionString))
                    {
                        conn.Open();

                        // 🔍 Debug: Muestra el CIME que se va a buscar
                       

                        string query = "SELECT material_electoral FROM material_electoral WHERE cime = @cime";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@cime", cime);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    descripcion = reader["material_electoral"].ToString();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }

                return descripcion;
            }


            public static string FormatearCIME(string cime)
            {
                cime = cime.Trim();

                if (cime.Length == 6) // Ajusta esto según la estructura real del CIME
                {
                    return cime.Substring(0, 2) + " " + cime.Substring(2, 1) + " " + cime.Substring(3, 1) + " " + cime.Substring(4);
                }

                return cime; // Si no tiene la longitud correcta, devolverlo como está
            }
        }

        private void txtZore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAre.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtAre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNombre.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtArticulos.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtArticulos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgregarArticulo();
                e.SuppressKeyPress = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GuardarDatosGenerales(); // Se encarga de validar y limpiar los campos
            AgregarArticulo(); // Agrega el artículo
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtZore.Clear();
            txtAre.Clear();
            txtNombre.Clear();
            txtArticulos.Clear();
            dgvArticulos.Rows.Clear();
        }

        private void GuardarDatosGenerales()
        {
            string zore = txtZore.Text.Trim();
            string are = txtAre.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string fecha = DateTime.Now.ToString("dd/MM/yyyy");

            if (string.IsNullOrEmpty(zore) || string.IsNullOrEmpty(are) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Faltan datos. Asegúrese de llenar ZORE, ARE y Nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvDatosGenerales.Rows.Clear();
            dgvDatosGenerales.Rows.Add(new object[] { zore, are, nombre, fecha });
        }

        private void AgregarArticulo()
        {
            string codigo = txtArticulos.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                
                return;
            }

            Match match = Regex.Match(codigo, @"^\D*(\d{4})([\w\s]{6,10})(\d{4})\D*$");

            if (match.Success)
            {
                string cime = match.Groups[2].Value.Trim(); // Elimina espacios innecesarios

                // 🔍 Formateamos CIME antes de enviarlo a la base de datos
                string cimeFormateado = ConexionMySQL.FormatearCIME(cime);
                

                string numero = match.Groups[3].Value;

                // 🔍 Obtén la descripción desde la BD
                string material = ConexionMySQL.ObtenerDescripcionDesdeBD(cimeFormateado);
               

                if (!string.IsNullOrEmpty(material))
                {
                    // ✅ Agregar al DataGridView SOLO si encuentra el material
                    dgvArticulos.Rows.Add(new object[] { codigo, cimeFormateado, numero, material });
                    txtArticulos.Clear();
                }
                else
                {
                    MessageBox.Show("No se encontró el artículo en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Formato de código incorrecto. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            float yPos = 50;
            int xPos = 50;

            e.Graphics.DrawString("Datos Generales", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, xPos, yPos);
            yPos += 30;

            // Imprimir dgvDatosGenerales
            foreach (DataGridViewRow row in dgvDatosGenerales.Rows)
            {
                if (!row.IsNewRow)
                {
                    string line = "";
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        line += cell.Value?.ToString() + "   ";
                    }
                    e.Graphics.DrawString(line, font, Brushes.Black, xPos, yPos);
                    yPos += 20;
                }
            }

            yPos += 30;
            e.Graphics.DrawString("Artículos", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, xPos, yPos);
            yPos += 30;

            // Imprimir dgvArticulos
            foreach (DataGridViewRow row in dgvArticulos.Rows)
            {
                if (!row.IsNewRow)
                {
                    string line = "";
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        line += cell.Value?.ToString() + "   ";
                    }
                    e.Graphics.DrawString(line, font, Brushes.Black, xPos, yPos);
                    yPos += 20;
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void btnGuardarFolio_Click_1(object sender, EventArgs e)
        {
            // Conexión a MySQL
            string conexionString = "Server=localhost;Port=3306;Database=ine;User Id=root;Password=21082007jd;";
            using (MySqlConnection conn = new MySqlConnection(conexionString))
            {
                conn.Open();

                // Obtener el siguiente ID de folio
                string queryFolio = "SELECT IFNULL(MAX(id_folio), 0) + 1 FROM folio";
                int nuevoFolio = 1;

                using (MySqlCommand cmdFolio = new MySqlCommand(queryFolio, conn))
                {
                    object result = cmdFolio.ExecuteScalar();
                    if (result != null)
                    {
                        nuevoFolio = Convert.ToInt32(result);
                    }
                }

                MessageBox.Show("Nuevo Folio Asignado: " + nuevoFolio, "Debug");

                foreach (DataGridViewRow row in dgvArticulos.Rows)
                {
                    if (row.Cells[0].Value == null) continue;

                    string codigoArticulo = row.Cells[0].Value.ToString();
                    string cime = row.Cells[1].Value.ToString();
                    string numeroMaterial = row.Cells[2].Value.ToString();

                    // 🔎 Verificar id_material_electoral
                    string queryMaterial = "SELECT id_material_electoral FROM material_electoral WHERE cime = @cime";
                    int idMaterialElectoral = -1;

                    using (MySqlCommand cmdMaterial = new MySqlCommand(queryMaterial, conn))
                    {
                        cmdMaterial.Parameters.AddWithValue("@cime", cime);
                        object result = cmdMaterial.ExecuteScalar();
                        if (result != null)
                        {
                            idMaterialElectoral = Convert.ToInt32(result);
                        }
                    }

                    if (idMaterialElectoral == -1)
                    {
                        MessageBox.Show("No se encontró material para CIME: " + cime, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    MessageBox.Show("Material encontrado - ID: " + idMaterialElectoral, "Debug");

                    // 🔎 Verificar si hay datos en la tabla empleados antes de hacer la consulta
                    string verificarEmpleados = "SELECT COUNT(*) FROM empleados";
                    int totalEmpleados = 0;

                    using (MySqlCommand cmdVerificar = new MySqlCommand(verificarEmpleados, conn))
                    {
                        totalEmpleados = Convert.ToInt32(cmdVerificar.ExecuteScalar());
                    }

                    if (totalEmpleados == 0)
                    {
                        MessageBox.Show("No hay datos en la tabla 'empleados'. No se puede obtener el ID del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Salir de la función para evitar errores
                    }

                    // 🔎 Verificar id_empleados asegurando mayúsculas/minúsculas
                    string queryEmpleado = "SELECT id_empleados FROM empleados WHERE BINARY Are = @are";
                    int idEmpleado = -1;

                    using (MySqlCommand cmdEmpleado = new MySqlCommand(queryEmpleado, conn))
                    {
                        cmdEmpleado.Parameters.AddWithValue("@are", txtAre.Text.Trim());

                        object result = cmdEmpleado.ExecuteScalar();
                        if (result != null)
                        {
                            idEmpleado = Convert.ToInt32(result);
                        }
                    }

                    if (idEmpleado == -1)
                    {
                        MessageBox.Show($"No se encontró empleado para ARE: {txtAre.Text.Trim()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Empleado encontrado - ID: " + idEmpleado, "Debug");


                    // 🔎 Insertar en la tabla folio
                    string insertQuery = "INSERT INTO folio (id_folio, id_material_electoral, codigo_articulo, id_empleados, numeral_material_electoral) " +
                                         "VALUES (@folio, @idMaterial, @codigo, @idEmpleado, @numeral)";

                    using (MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@folio", nuevoFolio);
                        cmdInsert.Parameters.AddWithValue("@idMaterial", idMaterialElectoral);
                        cmdInsert.Parameters.AddWithValue("@codigo", codigoArticulo);
                        cmdInsert.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                        cmdInsert.Parameters.AddWithValue("@numeral", numeroMaterial);

                        int filasAfectadas = cmdInsert.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Folio guardado correctamente.", "Éxito");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el folio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void GuardarFolioEnBD(int idFolio, int idMaterialElectoral, string codigoArticulo, int idEmpleado, string numeralMaterial)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=ine;User Id=root;Password=21082007jd;"))
                {
                    conn.Open();
                    string query = "INSERT INTO folio (id_folio, id_material_electoral, codigo_articulo, id_empleados, numeral_material_electoral) " +
                                   "VALUES (@idFolio, @idMaterial, @codigo, @idEmpleado, @numeral)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idFolio", idFolio);
                        cmd.Parameters.AddWithValue("@idMaterial", idMaterialElectoral);
                        cmd.Parameters.AddWithValue("@codigo", codigoArticulo);
                        cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                        cmd.Parameters.AddWithValue("@numeral", numeralMaterial);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
       
    }
}