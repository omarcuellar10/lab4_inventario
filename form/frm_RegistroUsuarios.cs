using Lab4_inventario.cs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_inventario.form
{
    public partial class frm_RegistroUsuarios : Form
    {
        public frm_RegistroUsuarios(int? id = null)
        {
            InitializeComponent();
        }
       
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            frm_Configuracion configuracion = new frm_Configuracion();
            configuracion.Show();
            this.Hide();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string username = tx_Usuario.Text.Trim();
            string password = tx_Password.Text.Trim();
            string pass_confirm = tx_Pass_Confirm.Text.Trim();
            string nombre = tx_Nombre.Text.Trim();
            string apellido = tx_Apellido.Text.Trim();
            string correo = tx_Correo.Text.Trim();
            string nombrerol = cbox_rol.Text.Trim();
            bool activo = true;
            DateTime hora_ingreso = DateTime.Now;
            string mensajeError;
         

             if (Fn_varias.UsuarioExiste(username))
             {
                 MessageBox.Show("El nombre de usuario o correo ya está en uso.");
                // username = "";
                 return;
             }
            
               if (!Fn_varias.ValidarDatosUsuario(username, password, pass_confirm, nombre, apellido, correo, out mensajeError))
            {
                MessageBox.Show(mensajeError);
                return;
            }


            try
            {
                Registro_usuario Reg_user = new Registro_usuario();
                Reg_user.Insertar_Usuario(username, password, nombre, apellido, correo, nombrerol, activo, hora_ingreso);
                MessageBox.Show("Usuario guardado exitosamente.");

                Fn_varias fn_Varias = new Fn_varias();
                fn_Varias.Clear_TBox(this); // Llamar al método para limpiar los TextBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el usuario: " + ex.Message);
            }
        }

        private void frm_RegistroUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lab4_inventarioDataSet.rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.lab4_inventarioDataSet.rol);

        }





        /*private void frm_RegistroUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lab4_inventarioDataSet.rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.lab4_inventarioDataSet.rol);

        }*/
    }

}





