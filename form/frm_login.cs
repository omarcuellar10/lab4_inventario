using Lab4_inventario.cs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Lab4_inventario.form;



namespace Lab4_inventario
{
   
    public partial class frm_login : Form
    {
        public static string nombre_user_login;
        public static int id_rol;
        public static int id_sesion_g;
        public static DateTime hora_ingreso;
        public frm_login()
        {
            InitializeComponent();
        }
        
       
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }







        private void btn_Ingreso_Click(object sender, EventArgs e)
        {
            string username = tx_usuario.Text.Trim();
            string password = tx_Password.Text.Trim();
            bool activo = true;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor ingrese el nombre de usuario y la contraseña.");
                return;
            }

            DBConnection conn = new DBConnection();
            using (SqlConnection connection = conn.ObtenerConexion())
            {
               try
               {
                    connection.Open();
                 
                    // Crear el comando con parámetros
                    string query = "SELECT * FROM login_usuarios WHERE usuario = @username AND usuario_pass = @password and estado = @activo" ;
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@activo", activo);

                // Mostrar los parámetros para depuración
               
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {                      
                        nombre_user_login = username;
                        Login login = new Login();
                        login.insertar_sesion();
                        // Asume que tienes un TextBox llamado txtUsername
                        int? rol = login.ObtenerRol(username);
                        id_rol = Convert.ToInt32(rol);
                        int? idsesion = login.ObtenerIdSesion(hora_ingreso, username);
                        id_sesion_g = Convert.ToInt32(idsesion);

                        // frm_MenuPrincipal principal = new frm_MenuPrincipal(Usr_lgn);
                        frm_MenuPrincipal principal = new frm_MenuPrincipal();
                        connection.Close();
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login inválido. Por favor, verifique sus credenciales.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
                
    }
}
