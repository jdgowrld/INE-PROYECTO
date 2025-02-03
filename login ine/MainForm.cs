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

        // Método para obtener la descripción del artículo
        public static string ObtenerDescripcionDesdeBD(string codigo)
        {
            string descripcion = string.Empty;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexionString))
                {
                    conn.Open();
                    string query = "SELECT descripcion FROM articulos WHERE codigo = @codigo";  // Ajusta según tu tabla
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                descripcion = reader["descripcion"].ToString();
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


        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvArticulos.Columns.Add("Codigo", "Código");
            dgvArticulos.Columns.Add("Descripcion", "Descripción");
            dgvArticulos.Columns.Add("Cantidad", "Cantidad");
        }


        private void txtZore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAre.Focus();  // Cambia el foco al siguiente campo
                e.SuppressKeyPress = true; // Evita que el Enter haga un sonido o agregue saltos de línea
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
                string codigo = txtArticulos.Text.Trim();

                if (!string.IsNullOrEmpty(codigo))
                {
                    // Aquí puedes conectar con MySQL y obtener la descripción del artículo
                    string descripcion = ObtenerDescripcionDesdeBD(codigo); // Simulación de función
                    int cantidad = 1;

                    // Agregar al DataGridView
                    dgvArticulos.Rows.Add(codigo, descripcion, cantidad);

                    // Limpiar el campo para el siguiente escaneo
                    txtArticulos.Clear();
                }

                e.SuppressKeyPress = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string codigo = txtArticulos.Text.Trim();

            if (!string.IsNullOrEmpty(codigo))
            {
                string descripcion = ObtenerDescripcionDesdeBD(codigo);
                int cantidad = 1;

                dgvArticulos.Rows.Add(codigo, descripcion, cantidad);
                txtArticulos.Clear();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtZore.Clear();
            txtAre.Clear();
            txtNombre.Clear();
            txtArticulos.Clear();
            dgvArticulos.Rows.Clear();
    }
}
}
