using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_inventario.cs
{
    public class Registro_usuario
    {
        private DBConnection conn;

        public Registro_usuario()
        {
            conn = new DBConnection();
        }

        public void Insertar_Usuario(string username, string password, string nombre, string apellido, string correo, string nombrerol, bool activo, DateTime hora_ingreso)
        {
            using (SqlConnection connection = conn.ObtenerConexion())
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // inserta en el login los datos registrados
                        string query_login = "INSERT INTO login_usuarios(usuario, usuario_pass, estado, fecha_habilitado) " +
                                             "VALUES(@username, @password, @activo, @fechaactual)";
                        SqlCommand cmd_login = new SqlCommand(query_login, connection, transaction);
                        cmd_login.Parameters.AddWithValue("@username", username);
                        cmd_login.Parameters.AddWithValue("@password", password);
                        cmd_login.Parameters.AddWithValue("@activo", activo);
                        cmd_login.Parameters.AddWithValue("@fechaactual", hora_ingreso);
                       
                        cmd_login.ExecuteNonQuery();

                        // inserta en el usuario los datos registrados
                        string query_users = "INSERT INTO usuario (nombre, apellido, correo, id_login, id_rol) VALUES (" +
                                             "@nombre, @apellido, @correo, " +
                                             "(SELECT id_login FROM login_usuarios WHERE usuario = @username), " +
                                             "(SELECT id_rol FROM rol WHERE nombre = @nombrerol))";
                        SqlCommand cmd_user = new SqlCommand(query_users, connection, transaction);
                        cmd_user.Parameters.AddWithValue("@nombre", nombre);
                        cmd_user.Parameters.AddWithValue("@apellido", apellido);
                        cmd_user.Parameters.AddWithValue("@correo", correo);
                        cmd_user.Parameters.AddWithValue("@username", username);
                        cmd_user.Parameters.AddWithValue("@password", password);
                        cmd_user.Parameters.AddWithValue("@nombrerol", nombrerol);
                        cmd_user.ExecuteNonQuery();

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
        

      

    }

}

