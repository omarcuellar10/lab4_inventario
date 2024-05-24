using Lab4_inventario.form;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_inventario.cs
{
    internal class Editar_Usuario
    {

        public Editar_Usuario()
        {

        }


        /*public void editar_usuario(int id_usuario, string nombre, string apellido, string correo, 
            string username, string password, string rol, bool estado) 
        {
            DateTime edicion = DateTime.Now;
            DBConnection conn = new DBConnection();
            using (SqlConnection connection = conn.ObtenerConexion())
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Actualiza el estado de la sesión y la hora de salida en la tabla 'sesion'
                        string query_usuario = "UPDATE usuario " +
                                              "SET nombre = @estado, apellido = @apellido, " +
                                              "correo = @correo, id_rol = (select id_rol from rol where nombre = @rol) "+
                                              "WHERE id_usuario = @idusuario";
                        SqlCommand cmd_usuario = new SqlCommand(query_usuario, connection, transaction);
                        cmd_usuario.Parameters.AddWithValue("@nombre", nombre);
                        cmd_usuario.Parameters.AddWithValue("@apellido", apellido);
                        cmd_usuario.Parameters.AddWithValue("@idusuario", id_usuario);
                        cmd_usuario.Parameters.AddWithValue("@correo", correo);
                        cmd_usuario.Parameters.AddWithValue("@rol", rol);
                        cmd_usuario.ExecuteNonQuery();

                        // Realiza el commit de la transacción
                      
                        // Actualiza el estado de la sesión y la hora de salida en la tabla 'sesion'
                        string query_login = "UPDATE login_usuarios " +
                                              "SET estado = @estado, usuario = @username, usuario_pass = password, fecha_deshabilitado =  " +
                                              "WHERE id_login = (select id_login from usuario where id_usuario = @idusuario) ";
                        SqlCommand cmd_login = new SqlCommand(query_login, connection, transaction);
                        cmd_login.Parameters.AddWithValue("@estado", estado);
                        cmd_login.Parameters.AddWithValue("@username", username);
                        cmd_login.Parameters.AddWithValue("@password", password);
                        cmd_login.Parameters.AddWithValue("@idusuario", id_usuario);
                        cmd_login.Parameters.AddWithValue("@edicion", edicion);
                        cmd_login.ExecuteNonQuery();

                        // Realiza el commit de la transacción
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Revierte la transacción en caso de error
                        transaction.Rollback();
                        // Aquí puedes manejar el error de alguna manera, por ejemplo, registrándolo o mostrándolo
                        MessageBox.Show("Error al editar: " + ex.Message);
                        throw;
                    }
                }
                connection.Close();
            }
        }
        */


        public void editar_usuario(int id_usuario, string nombre, string apellido, string correo,
                           string username, string password, string rol, bool estado, string passconfirm)
        {
            /*

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
            }*/


            DateTime edicion = DateTime.Now;
            DBConnection conn = new DBConnection();
            using (SqlConnection connection = conn.ObtenerConexion())
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Actualiza la información del usuario en la tabla 'usuario'
                        string query_usuario = "UPDATE usuario " +
                                               "SET nombre = @nombre, apellido = @apellido, " +
                                               "correo = @correo, id_rol = (SELECT id_rol FROM rol WHERE nombre = @rol) " +
                                               "WHERE id_usuario = @idusuario";
                        SqlCommand cmd_usuario = new SqlCommand(query_usuario, connection, transaction);
                        cmd_usuario.Parameters.AddWithValue("@nombre", nombre);
                        cmd_usuario.Parameters.AddWithValue("@apellido", apellido);
                        cmd_usuario.Parameters.AddWithValue("@idusuario", id_usuario);
                        cmd_usuario.Parameters.AddWithValue("@correo", correo);
                        cmd_usuario.Parameters.AddWithValue("@rol", rol);
                        cmd_usuario.ExecuteNonQuery();

                        // Actualiza la información del login en la tabla 'login_usuarios'
                        string query_login = "UPDATE login_usuarios " +
                                             "SET estado = @estado, usuario = @username, usuario_pass = @password, ultima_edicion = @edicion " +
                                             "WHERE id_login = (SELECT id_login FROM usuario WHERE id_usuario = @idusuario)";
                        SqlCommand cmd_login = new SqlCommand(query_login, connection, transaction);
                        cmd_login.Parameters.AddWithValue("@estado", estado);
                        cmd_login.Parameters.AddWithValue("@username", username);
                        cmd_login.Parameters.AddWithValue("@password", password);
                        cmd_login.Parameters.AddWithValue("@idusuario", id_usuario);
                        cmd_login.Parameters.AddWithValue("@edicion", edicion);
                        cmd_login.ExecuteNonQuery();

                        // Realiza el commit de la transacción
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Revierte la transacción en caso de error
                        transaction.Rollback();
                        // Aquí puedes manejar el error de alguna manera, por ejemplo, registrándolo o mostrándolo
                        MessageBox.Show("Error al editar: " + ex.Message);
                        throw;
                    }
                    finally
                    {
                        // Cierra la conexión
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }



    }
}
