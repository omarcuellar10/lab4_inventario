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
    public class Menu_principal
    {
        private DBConnection conn;

        public Menu_principal()
        {
            conn = new DBConnection();
        }

        //prueba 1 abajo
        /*   public void cerrar_sesion()
           {
               string estado = "Cerrada";
               DateTime salida = DateTime.Now;
               int idsesion = frm_login.id_sesion_g;

               DBConnection conn = new DBConnection();
               using (SqlConnection connection = conn.ObtenerConexion())
               {
                   connection.Open();

                   using (SqlTransaction transaction = connection.BeginTransaction())
                   {
                       try
                       {
                           // inserta en el login los datos registrados
                           string query_logout= "update sesion " +
                                               "set estado_sesion = @estado, salida = @salida " +
                                                "where id_sesion = @idesesion))";
                           SqlCommand cmd_logout = new SqlCommand(query_logout, connection, transaction);
                           cmd_logout.Parameters.AddWithValue("@estado", estado);
                           cmd_logout.Parameters.AddWithValue("@salida", salida);
                           cmd_logout.Parameters.AddWithValue("@idsesion", idsesion);
                           cmd_logout.ExecuteNonQuery();

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
           }*/

        //prueba 2 abajo:
        public void cerrar_sesion()
        {
            string estado = "Cerrada";
            DateTime salida = DateTime.Now;
            int idsesion = frm_login.id_sesion_g;

            DBConnection conn = new DBConnection();
            using (SqlConnection connection = conn.ObtenerConexion())
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Actualiza el estado de la sesión y la hora de salida en la tabla 'sesion'
                        string query_logout = "UPDATE sesion " +
                                              "SET estado_sesion = @estado, salida = @salida " +
                                              "WHERE id_sesion = @idsesion";
                        SqlCommand cmd_logout = new SqlCommand(query_logout, connection, transaction);
                        cmd_logout.Parameters.AddWithValue("@estado", estado);
                        cmd_logout.Parameters.AddWithValue("@salida", salida);
                        cmd_logout.Parameters.AddWithValue("@idsesion", idsesion);
                        cmd_logout.ExecuteNonQuery();

                        // Realiza el commit de la transacción
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Revierte la transacción en caso de error
                        transaction.Rollback();
                        // Aquí puedes manejar el error de alguna manera, por ejemplo, registrándolo o mostrándolo
                        MessageBox.Show("Error al cerrar sesión: " + ex.Message);
                        throw;
                    }
                }
            }
        }

    }
}
