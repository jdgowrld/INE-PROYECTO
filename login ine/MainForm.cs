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
            public static string ObtenerDescripcionDesdeBD(string codigo)
            {
                string descripcion = string.Empty;
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(conexionString))
                    {
                        conn.Open();
                        string query = @"
                SELECT me.material_electoral 
                FROM material_electoral me
                JOIN folio f ON me.id_material_electoral = f.id_material_electoral
                WHERE f.codigo_articulo = @codigo";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@codigo", codigo);
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
            if (dgvDatosGenerales.Rows.Count == 0) // Si el DataGridView está vacío, hacer la validación
            {
                if (string.IsNullOrEmpty(txtZore.Text.Trim()) || string.IsNullOrEmpty(txtAre.Text.Trim()) || string.IsNullOrEmpty(txtNombre.Text.Trim()))
                {
                    MessageBox.Show("Faltan datos. Asegúrese de llenar ZORE, ARE y Nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                GuardarDatosGenerales();
            }

            AgregarArticulo(); // Ahora sí agregamos el artículo sin problemas
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
            string fecha = DateTime.Now.ToString("dd/MM/yyyy"); // Formato de fecha

            if (string.IsNullOrEmpty(zore) || string.IsNullOrEmpty(are) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Faltan datos. Asegúrese de llenar ZORE, ARE y Nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Limpiar para que solo haya una fila con estos datos
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

            Match match = Regex.Match(codigo, @"^\D*(\d{4})(\w{6})(\d{4})\D*$");

            if (match.Success)
            {
                string cime = match.Groups[2].Value;
                string numero = match.Groups[3].Value;

                dgvArticulos.Rows.Add(new object[] { codigo, cime, numero });

                txtArticulos.Clear();
            }
            else
            {
                MessageBox.Show("Formato de código incorrecto. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

       

      
    }
}
