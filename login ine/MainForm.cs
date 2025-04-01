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
using System.Data.SqlClient;

namespace login_ine
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            printDocumentSalidas.PrintPage += new PrintPageEventHandler(PrintDocumentSalida_PrintPage);

        }

        private static string conexionString = "Server=localhost;Port=3306;Database=ine;User Id=root;Password=21082007jd;";
        private PrintDocument printDocumentSalidas = new PrintDocument();


        public static class ConexionMySQL
        {
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
            dgvDatosGenerales.Rows.Clear();
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
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);
            float yPos = 50;
            int xPos = 50;

            // Encabezado
            e.Graphics.DrawString("SALIDA DE MATERIAL ELECTORAL", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, xPos, yPos);
            yPos += 30;

            // Datos Generales
            e.Graphics.DrawString("ZORE:", boldFont, Brushes.Black, xPos, yPos);
            e.Graphics.DrawString(dgvDatosGenerales.Rows[0].Cells[0].Value?.ToString(), font, Brushes.Black, xPos + 50, yPos);

            e.Graphics.DrawString("ARE:", boldFont, Brushes.Black, xPos + 150, yPos);
            e.Graphics.DrawString(dgvDatosGenerales.Rows[0].Cells[1].Value?.ToString(), font, Brushes.Black, xPos + 200, yPos);

            e.Graphics.DrawString("Nombre:", boldFont, Brushes.Black, xPos + 300, yPos);
            e.Graphics.DrawString(dgvDatosGenerales.Rows[0].Cells[2].Value?.ToString(), font, Brushes.Black, xPos + 370, yPos);

            e.Graphics.DrawString("Fecha:", boldFont, Brushes.Black, xPos + 500, yPos);
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), font, Brushes.Black, xPos + 550, yPos);

            yPos += 40;

            // Encabezado de artículos
            e.Graphics.DrawString("Código Artículo", boldFont, Brushes.Black, xPos, yPos);
            e.Graphics.DrawString("CIME", boldFont, Brushes.Black, xPos + 150, yPos);
            e.Graphics.DrawString("Número", boldFont, Brushes.Black, xPos + 300, yPos);
            e.Graphics.DrawString("Nombre", boldFont, Brushes.Black, xPos + 400, yPos);

            yPos += 20;

            // Imprimir Artículos
            foreach (DataGridViewRow row in dgvArticulos.Rows)
            {
                if (!row.IsNewRow)
                {
                    e.Graphics.DrawString(row.Cells["Codigo_Artículo"].Value?.ToString(), font, Brushes.Black, xPos, yPos);
                    e.Graphics.DrawString(row.Cells["CIME"].Value?.ToString(), font, Brushes.Black, xPos + 150, yPos);
                    e.Graphics.DrawString(row.Cells["NumeralMaterial"].Value?.ToString(), font, Brushes.Black, xPos + 300, yPos);
                    e.Graphics.DrawString(row.Cells["Column4"].Value?.ToString(), font, Brushes.Black, xPos + 400, yPos);
                    yPos += 20;
                }
            }

            float firmaY = e.MarginBounds.Bottom - 80; // Ajuste para ponerla al final
            float nombreY = firmaY + 40; // Espacio entre firma y nombre

            // Línea de firma
            e.Graphics.DrawLine(Pens.Black, xPos, firmaY, xPos + 300, firmaY);
            e.Graphics.DrawString("Firma de quien recibe", font, Brushes.Black, xPos + 50, firmaY + 5);

            // Línea para el nombre
            e.Graphics.DrawLine(Pens.Black, xPos, nombreY, xPos + 300, nombreY);
            e.Graphics.DrawString("Nombre de quien recibe", font, Brushes.Black, xPos + 50, nombreY + 5);
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
            GuardarFolioEnBD();
        }
        private void GuardarFolioEnBD()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=ine;User Id=root;Password=21082007jd;"))
                {
                    conn.Open();
                    int idEmpleado = ObtenerIdEmpleado(conn, txtAre.Text.Trim());

                    if (idEmpleado == -1)
                    {
                        MessageBox.Show("No se encontró el empleado con ese ARE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int numeroFolio = ObtenerNuevoNumeroFolio(conn); // Se genera solo una vez

                    foreach (DataGridViewRow row in dgvArticulos.Rows)
                    {
                        if (row.Cells["Codigo_Artículo"].Value != null)
                        {
                            int idFolio = ObtenerNuevoIdFolio(conn);
                            string codigoArticulo = row.Cells["Codigo_Artículo"].Value.ToString();
                            string numeralMaterial = row.Cells["NumeralMaterial"].Value?.ToString() ?? "";
                            string cime = row.Cells["CIME"].Value?.ToString() ?? ""; // 🔥 Obtenemos el CIME desde el dgv

                            int idMaterialElectoral = ObtenerIdMaterialElectoral(conn, cime); // 🔍 Buscamos el ID en la BD

                            string query = @"INSERT INTO folio (id_folio, id_material_electoral, codigo_articulo, id_empleados, numeral_material_electoral, numero_folio) 
                                     VALUES (@idFolio, @idMaterial, @codigo, @idEmpleado, @numeral, @numFolio)";

                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@idFolio", idFolio);
                                cmd.Parameters.AddWithValue("@idMaterial", idMaterialElectoral);
                                cmd.Parameters.AddWithValue("@codigo", codigoArticulo);
                                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                                cmd.Parameters.AddWithValue("@numeral", numeralMaterial);
                                cmd.Parameters.AddWithValue("@numFolio", numeroFolio);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Folio guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerNuevoIdFolio(MySqlConnection conn)
        {
            string query = "SELECT COALESCE(MAX(id_folio), 0) + 1 FROM folio";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private int ObtenerIdEmpleado(MySqlConnection conn, string are)
        {
            string query = "SELECT id_empleados FROM empleados WHERE ARE = @are";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@are", are);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        private int ObtenerNuevoNumeroFolio(MySqlConnection conn)
        {
            string query = "SELECT COALESCE(MAX(numero_folio), 0) + 1 FROM folio";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private int ObtenerIdMaterialElectoral(MySqlConnection conn, string cime)
        {
            string query = "SELECT id_material_electoral FROM material_electoral WHERE cime = @cime LIMIT 1";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@cime", cime);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1; // Devuelve -1 si no se encuentra
            }
        }


        private void btnCargarFolio_Click_1(object sender, EventArgs e)
        {
            CargarArticulos();
        }

        private void CargarArticulos()
        {
            dgvEntradas.Rows.Clear();
            int contador = 0; // Contador para mostrar cuántos artículos se encontraron

            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=ine;User Id=root;Password=21082007jd;"))
                {
                    string query = @"SELECT f.codigo_articulo, me.cime, me.material_electoral, f.recibido
                    FROM folio f
                    JOIN material_electoral me ON f.id_material_electoral = me.id_material_electoral
                    WHERE f.numero_folio = @numero_folio";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@numero_folio", txtFolio.Text.Trim());

                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Verificar si ya está recibido
                        bool recibido = Convert.ToBoolean(reader["recibido"]);
                        string estado = recibido ? "Recibido" : "Pendiente";

                        int rowIndex = dgvEntradas.Rows.Add(reader["codigo_articulo"].ToString(),
                                                            reader["cime"].ToString(),
                                                            reader["material_electoral"].ToString(),
                                                            estado);
                        contador++;

                        // Si ya está recibido, cambiar color de la fila
                        if (recibido)
                        {
                            dgvEntradas.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                        }
                    }
                    reader.Close();
                }
                MessageBox.Show($"Se encontraron {contador} artículos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los artículos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEscaner_TextChanged_1(object sender, EventArgs e)
        {
            if (txtEscaner.Text.Length < 3) return; // Evita leer si el código es muy corto

            string codigo = txtEscaner.Text.Trim();
            foreach (DataGridViewRow row in dgvEntradas.Rows)
            {
                if (row.Cells["codigo_articulo"].Value != null &&
                    row.Cells["codigo_articulo"].Value.ToString() == codigo &&
                    row.Cells["estado"].Value.ToString() == "Pendiente")
                {
                    row.Cells["estado"].Value = "Recibido";
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                    RegistrarEntrada(codigo);
                    txtEscaner.Clear();
                    return;
                }
            }

            MessageBox.Show("Código no encontrado o ya registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtEscaner.Clear();
        }

        private void RegistrarEntrada(string codigoArticulo)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=ine;User Id=root;Password=21082007jd;"))
                {
                    // Solo actualizar si recibido = 0
                    string query = "UPDATE folio SET recibido = 1 WHERE codigo_articulo = @codigo_articulo AND recibido = 0";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@codigo_articulo", codigoArticulo);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas == 0)
                    {
                        MessageBox.Show("El artículo ya estaba marcado como recibido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                VerificarFinalizacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarFinalizacion()
        {
            foreach (DataGridViewRow row in dgvEntradas.Rows)
            {
                if (row.Cells["estado"].Value != null && row.Cells["estado"].Value.ToString() == "Pendiente")
                {
                    return; // Si hay al menos un pendiente, aún no está finalizado
                }
            }
            MessageBox.Show("Todos los artículos han sido recibidos.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            dgvEntradas.Rows.Clear();
            txtFolio.Clear();
            txtEscaner.Clear();
        }

        private void PrintDocumentSalida_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);
            float yPos = 50;
            int xPos = 50;

            // Encabezado
            e.Graphics.DrawString("RECIBO DE MATERIAL ELECTORAL", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, xPos, yPos);
            yPos += 30;

            // Encabezado de artículos
            e.Graphics.DrawString("Código Artículo", boldFont, Brushes.Black, xPos, yPos);
            e.Graphics.DrawString("CIME", boldFont, Brushes.Black, xPos + 150, yPos);
            e.Graphics.DrawString("Material Electoral", boldFont, Brushes.Black, xPos + 300, yPos);
            e.Graphics.DrawString("Estado", boldFont, Brushes.Black, xPos + 550, yPos); // Movido más a la derecha

            yPos += 20;

            // Imprimir Artículos desde dgvEntradas
            foreach (DataGridViewRow row in dgvEntradas.Rows)
            {
                if (!row.IsNewRow)
                {
                    e.Graphics.DrawString(row.Cells["codigo_articulo"].Value?.ToString(), font, Brushes.Black, xPos, yPos);
                    e.Graphics.DrawString(row.Cells["cime_entradas"].Value?.ToString(), font, Brushes.Black, xPos + 150, yPos);
                    e.Graphics.DrawString(row.Cells["material_electoral"].Value?.ToString(), font, Brushes.Black, xPos + 300, yPos);
                    e.Graphics.DrawString(row.Cells["estado"].Value?.ToString(), font, Brushes.Black, xPos + 550, yPos); // Movido más a la derecha
                    yPos += 20;
                }
            }

            // Ubicar la firma hasta el final de la hoja
            float firmaY = e.MarginBounds.Bottom - 80; // Ajuste para ponerla al final
            float nombreY = firmaY + 40; // Espacio entre firma y nombre

            // Línea de firma
            e.Graphics.DrawLine(Pens.Black, xPos, firmaY, xPos + 300, firmaY);
            e.Graphics.DrawString("Firma de quien recibe", font, Brushes.Black, xPos + 50, firmaY + 5);

            // Línea para el nombre
            e.Graphics.DrawLine(Pens.Black, xPos, nombreY, xPos + 300, nombreY);
            e.Graphics.DrawString("Nombre de quien recibe", font, Brushes.Black, xPos + 50, nombreY + 5);
        }

        private void btnImprimirSalida_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocumentSalidas;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocumentSalidas.Print();
            }
        }
    }
}
    
