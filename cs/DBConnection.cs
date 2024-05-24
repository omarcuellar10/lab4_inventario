using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_inventario.cs
{
    internal class DBConnection
    {

        private string ConnectionString = "Data Source=LGBSV-01064\\MSSQLSERVER01;Initial Catalog=Lab4_inventario;Integrated Security=True";

        public SqlConnection ObtenerConexion()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            return connection;
        }


    }
}
