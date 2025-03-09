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
                        MessageBox.Show("Buscando en BD CIME: '" + cime + "'", "Debug");

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
                MessageBox.Show("Ingrese un código de artículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Match match = Regex.Match(codigo, @"^\D*(\d{4})([\w\s]{6,10})(\d{4})\D*$");

            if (match.Success)
            {
                string cime = match.Groups[2].Value.Trim(); // Elimina espacios innecesarios

                // 🔍 Formateamos CIME antes de enviarlo a la base de datos
                string cimeFormateado = ConexionMySQL.FormatearCIME(cime);
                MessageBox.Show("CIME extraído y formateado: '" + cimeFormateado + "'", "Debug");

                string numero = match.Groups[3].Value;

                // 🔍 Obtén la descripción desde la BD
                string material = ConexionMySQL.ObtenerDescripcionDesdeBD(cimeFormateado);
                MessageBox.Show("Material obtenido: '" + material + "'", "Debug");

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

        private void btnGuardarFolio_Click(object sender, EventArgs e)
        {
            int nuevoFolio = ObtenerNuevoFolio();
            int idEmpleado = ObtenerIdEmpleado(txtAre.Text); // Obtener el id_empleado usando el ARE

            if (idEmpleado == -1)
            {
                MessageBox.Show("Error: No se encontró el empleado con el ARE proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow row in dgvArticulos.Rows)
            {
                if (!row.IsNewRow)
                {
                    string cime = row.Cells["CIME"].Value?.ToString();
                    int idMaterialElectoral = ObtenerIdMaterialElectoral(cime);
                    string codigoArticulo = row.Cells["Código"].Value?.ToString();
                    string numeralMaterial = row.Cells["Número"].Value?.ToString();

                    if (idMaterialElectoral == -1)
                    {
                        MessageBox.Show($"Error: No se encontró material electoral con CIME '{cime}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    GuardarFolioEnBD(nuevoFolio, idMaterialElectoral, codigoArticulo, idEmpleado, numeralMaterial);
                }
            }

            MessageBox.Show("Datos guardados correctamente en la tabla 'folio'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int ObtenerNuevoFolio()
        {
            int nuevoFolio = 1;
            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=ine;User Id=root;Password=21082007jd;"))
                {
                    conn.Open();
                    string query = "SELECT MAX(id_folio) FROM folio";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            nuevoFolio = Convert.ToInt32(result) + 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el folio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nuevoFolio;
        }

        private int ObtenerIdMaterialElectoral(string cime)
        {
            int idMaterialElectoral = -1;
            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=ine;User Id=root;Password=21082007jd;"))
                {
                    conn.Open();
                    string query = "SELECT id_material_electoral FROM material_electoral WHERE cime = @cime";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cime", cime);
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            idMaterialElectoral = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del material electoral: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return idMaterialElectoral;
        }

        private int ObtenerIdEmpleado(string are)
        {
            int idEmpleado = -1;
            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=ine;User Id=root;Password=21082007jd;"))
                {
                    conn.Open();
                    string query = "SELECT id_empleados FROM empleados WHERE are = @are";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@are", are);
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            idEmpleado = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return idEmpleado;
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
