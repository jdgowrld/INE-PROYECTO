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
    public partial class Form1 : Form
    {
        // Cadena de conexión: contiene la información para conectar a la base de datos MySQL.
        // Server: Dirección del servidor (en este caso, localhost para tu máquina local).
        // Port: Puerto en el que MySQL escucha (3306 por defecto).
        // Database: Nombre de la base de datos que estás usando (ine_inventario).
        // User Id: Usuario para la conexión (root).
        // Password: Contraseña del usuario.
        string cadenaConexion = "Server=localhost;Port=3306;Database=ine_inventario;User Id=root;Password=21082007jd;";

        public Form1()
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
        }
        // Evento asociado al clic en el label (o botón) para iniciar sesión.   
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Se obtiene el nombre de usuario y la contraseña ingresados por el usuario.
            string usuario = txtadmin.Text;
            string contrasena = txtContraseña.Text;

            // Llamamos a la función para autenticar al usuario.
            if (AutenticarUsuario(usuario, contrasena))
            {
                // Si la autenticación es exitosa, mostramos un mensaje.
                MessageBox.Show("Inicio de sesión exitoso", "Login");
            }
            else
            {
                // Si falla la autenticación, mostramos un mensaje de error.
                MessageBox.Show("Usuario o contraseña incorrectos", "Error");
            }
        }

        // Método para autenticar al usuario en la base de datos.
        // Recibe el nombre de usuario y la contraseña ingresados por el usuario.
        private bool AutenticarUsuario(string usuario, string contrasena)
        {
            bool resultado = false; // Variable para almacenar el resultado de la autenticación.

            // Consulta SQL para verificar si existe un usuario con las credenciales ingresadas.
            string query = "SELECT COUNT(*) FROM usuarios WHERE NombreUsuario = @Usuario AND Contrasena = @Contraseña";


            // Bloque para manejar la conexión a la base de datos.
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open(); // Abre la conexión con la base de datos.

                    // Preparamos el comando SQL con la consulta y los parámetros.
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        // Agregamos los valores para los parámetros de la consulta.
                        comando.Parameters.AddWithValue("@Usuario", usuario);
                        comando.Parameters.AddWithValue("@Contraseña", contrasena);

                        // Ejecutamos la consulta y obtenemos el resultado.
                        int count = Convert.ToInt32(comando.ExecuteScalar());

                        // Si el resultado es mayor a 0, significa que las credenciales son válidas.
                        resultado = count > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    // Capturamos errores específicos de MySQL y los mostramos.
                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Capturamos cualquier otro tipo de error y lo mostramos.
                    MessageBox.Show("Error general: " + ex.Message);
                }
            }

            // Retornamos el resultado de la autenticación (true si es válido, false si no lo es).
            return resultado;
        }

       
    }
}
