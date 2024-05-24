using Lab4_inventario.form;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace Lab4_inventario.cs
{
    public class Login
    {
        public int id_sesion_g;
        private DBConnection conn;
        
        public Login()
        {
            conn = new DBConnection();
        }

        //funciona el de abajo
         public void insertar_sesion()
         {
             string estado = "Abierta";
             DateTime ingreso = DateTime.Now;
             string username = frm_login.nombre_user_login;
             frm_login.hora_ingreso = ingreso;

             using (SqlConnection connection = conn.ObtenerConexion())
             {
                 connection.Open();

                 using (SqlTransaction transaction = connection.BeginTransaction())
                 {
                     try
                     {
                         // inserta en el login los datos registrados
                         string query_login = "INSERT INTO sesion(estado_sesion, ingreso, salida, id_login) " +
                                              "VALUES(@estado, @ingreso, @salida, (select id_login from login_usuarios where usuario = @username))";
                         SqlCommand cmd_login = new SqlCommand(query_login, connection, transaction);
                         cmd_login.Parameters.AddWithValue("@estado", estado);
                         cmd_login.Parameters.AddWithValue("@ingreso", ingreso);
                         cmd_login.Parameters.AddWithValue("@salida", ingreso);
                         cmd_login.Parameters.AddWithValue("@username", username);
                         cmd_login.ExecuteNonQuery();

                         // envia el query
                         transaction.Commit();
                     }
                     catch (Exception)
                     {
                         // revierte todo si hay un error
                         transaction.Rollback();
                         throw;
                     }
                 }
             }
         }

        /*public void insertar_sesion()
        {
            string estado = "Abierta";
            DateTime ingreso = DateTime.Now;
            string username = frm_login.nombre_user_login; // Asumiendo que "FrmLogin" es tu clase de formulario de inicio de sesión
            //FrmLogin.HoraIngreso = ingreso; // Esto parece ser un comentario, no estoy seguro de su utilidad en este contexto

            using (SqlConnection connection = conn.ObtenerConexion())
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Inserta en el login los datos registrados
                        string queryLogin = "INSERT INTO sesion(estado_sesion, ingreso, salida, id_login) " +
                                             "VALUES(@estado, @ingreso, @salida, (SELECT id_login FROM login_usuarios WHERE usuario = @username))";
                        SqlCommand cmdLogin = new SqlCommand(queryLogin, connection, transaction);
                        cmdLogin.Parameters.AddWithValue("@estado", estado);
                        cmdLogin.Parameters.AddWithValue("@ingreso", ingreso);
                        cmdLogin.Parameters.AddWithValue("@salida", ingreso);
                        cmdLogin.Parameters.AddWithValue("@username", username);
                        cmdLogin.ExecuteNonQuery();

                        // Obtiene el ID de sesión generado
                        string queryObtenerIdSesion = "SELECT SCOPE_IDENTITY()";
                        SqlCommand cmdObtenerIdSesion = new SqlCommand(queryObtenerIdSesion, connection, transaction);
                        id_sesion_g = Convert.ToInt32(cmdObtenerIdSesion.ExecuteScalar());

                        // Envía el query
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        // Revierte todo si hay un error
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }



        */



        public int? ObtenerRol(string username)
        {
            DBConnection conn = new DBConnection();

            using (SqlConnection connection = conn.ObtenerConexion())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id_rol FROM usuario WHERE id_login = (SELECT id_login FROM login_usuarios WHERE usuario = @username)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public int? ObtenerIdSesion(DateTime ingreso, string username)
        {
            DBConnection conn = new DBConnection();

            using (SqlConnection connection = conn.ObtenerConexion())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id_sesion FROM sesion WHERE ingreso = @ingreso and id_login = (select id_login from login_usuarios where usuario = @username)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ingreso", ingreso);
                    cmd.Parameters.AddWithValue("@username", username);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
