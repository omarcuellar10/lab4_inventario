using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_inventario.cs
{
    public class RegistroProveedor
    {

        private DBConnection conn;


        public RegistroProveedor()
        {
            conn = new DBConnection();
        }

        public void Insertar_Proveedor(string nombre, string nit, string categoria, string ncr, string giro, string tipoContribuyente, 
            string pais, string direccion, string tel1, string tel2, string RepresentanteLegal, string personaContacto,
            string correo, DateTime fechareg)
        {
            using (SqlConnection connection = conn.ObtenerConexion())
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // inserta en el login los datos registrados
                        string query_reg_proveedor = "INSERT INTO Proveedor (nombre, nit, categoria, ncr, giro, tipoContribuyente, " +
                                                  "pais, direccion, tel1, tel2, representanteLegal, personaContacto, correo, hora_ingreso) " +
                                                "VALUES(@nombre, @nit, " +
                                                "(SELECT id_categoria FROM Categorias WHERE nombre = @categoria), " +
                                                "@ncr, @giro, @tipocontribu, " +
                                                "(SELECT id_pais FROM Paises WHERE nombre = @pais), " +
                                                "@direccion, @tel1, @tel2, " +
                                                "@reprelegal, @personaContacto,@correo, @fechareg)";
                        SqlCommand cmd_reg_prov = new SqlCommand(query_reg_proveedor, connection, transaction);
                        cmd_reg_prov.Parameters.AddWithValue("@nombre", nombre);
                        cmd_reg_prov.Parameters.AddWithValue("@nit", nit);
                        cmd_reg_prov.Parameters.AddWithValue("@categoria", categoria);
                        cmd_reg_prov.Parameters.AddWithValue("@ncr", ncr);
                        cmd_reg_prov.Parameters.AddWithValue("@giro", giro);
                        cmd_reg_prov.Parameters.AddWithValue("@tipocontribu", tipoContribuyente);
                        cmd_reg_prov.Parameters.AddWithValue("@pais", pais);
                        cmd_reg_prov.Parameters.AddWithValue("@direccion", direccion);
                        cmd_reg_prov.Parameters.AddWithValue("@tel1", tel1);
                        cmd_reg_prov.Parameters.AddWithValue("@tel2", tel2);
                        cmd_reg_prov.Parameters.AddWithValue("@reprelegal", RepresentanteLegal);
                        cmd_reg_prov.Parameters.AddWithValue("@personaContacto", personaContacto);
                        cmd_reg_prov.Parameters.AddWithValue("@correo", correo);
                        cmd_reg_prov.Parameters.AddWithValue("@fechareg", fechareg);
                        cmd_reg_prov.ExecuteNonQuery();

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
