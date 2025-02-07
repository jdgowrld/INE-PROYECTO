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

            public static string ObtenerDescripcionDesdeBD(string codigo)
            {
                string descripcion = string.Empty;
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(conexionString))
                    {
                        conn.Open();
                        string query = "SELECT descripcion FROM folio WHERE codigo = @codigo";
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
            AgregarArticulo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtZore.Clear();
            txtAre.Clear();
            txtNombre.Clear();
            txtArticulos.Clear();
            dgvArticulos.Rows.Clear();
        }

        private void AgregarArticulo()
        {
            string codigo = txtArticulos.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingrese un código de artículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string descripcion = ConexionMySQL.ObtenerDescripcionDesdeBD(codigo);

            if (string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Artículo no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvArticulos.Rows.Add(new object[] { codigo, descripcion, 1 });
            txtArticulos.Clear();
        }
    }
}
