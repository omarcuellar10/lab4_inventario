using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_inventario.cs
{
    public class Fn_varias
    {

        //para limbiar todos los texbox de un form
        public void Clear_TBox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c.Controls.Count > 0)
                {
                    Clear_TBox(c); // Recursión para limpiar TextBox en controles contenedores (como Paneles, GroupBoxes, etc.)
                }
            }
        }

        public static bool correovalido(string correo)
        {
            // Regular expression for basic email structure
            const string restriccion = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            // Check if the email matches the basic structure
            if (!Regex.Match(correo, restriccion).Success)
            {
                return false;
            }


            return true;
        }

        public static bool UsuarioExiste(string username)
        {
            DBConnection conn = new DBConnection();

            using (SqlConnection connection = conn.ObtenerConexion())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM login_usuarios WHERE usuario = @username";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

     /*   public static void validaciones(string nombre, string apellido, string correo,
                           string username, string password, string rol, bool estado, string passconfirm)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(nombre)
                || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(passconfirm))

            {
                MessageBox.Show("Por favor llene todos los campos.");
                return;
            }

            if (password != passconfirm)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }


            if (!Fn_varias.correovalido(correo))
            {
                // Display error message or take appropriate action
                MessageBox.Show("ingrese un correo valido.");
                return;
            }

            if (Fn_varias.UsuarioExiste(username))
            {
                MessageBox.Show("El nombre de usuario o correo ya está en uso.");
                username = "";
                return;
            }
            
        }*/



        public static bool ValidarDatosUsuario(string username, string password, string pass_confirm, string nombre, string apellido, string correo, out string mensajeError)
        {
            mensajeError = string.Empty;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(nombre) ||
                string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(pass_confirm))
            {
                mensajeError = "Por favor llene todos los campos.";
                return false;
            }

            if (password != pass_confirm)
            {
                mensajeError = "Las contraseñas no coinciden.";
                return false;
            }

            if (!correovalido(correo))
            {
                mensajeError = "Ingrese un correo válido.";
                return false;
            }

           /* if (UsuarioExiste(username))
            {
                mensajeError = "El nombre de usuario o correo ya está en uso.";
                return false;
            }*/

            return true;
        }
    }

}

