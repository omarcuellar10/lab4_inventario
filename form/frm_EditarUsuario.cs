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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4_inventario.form
{
    public partial class frm_EditarUsuario : Form
    {
        public frm_EditarUsuario()
        {
            InitializeComponent();
            //deshabilitar_txbox(true);
        }

        private void frm_EditarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lab4_inventarioDataSet4.rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.lab4_inventarioDataSet4.rol);
            // TODO: esta línea de código carga datos en la tabla 'lab4_inventarioDataSet3.view_usuarios2' Puede moverla o quitarla según sea necesario.
            this.view_usuarios2TableAdapter.Fill(this.lab4_inventarioDataSet3.view_usuarios2);
          
            deshabilitar_txbox(true);
           

        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            frm_Configuracion configuracion = new frm_Configuracion();
            configuracion.Show();

            // Mostrar el segundo formulario
            this.Hide();
        }

        private void dgv_carga_vista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_carga_vista.Rows[e.RowIndex];
                bool activo = (bool)row.Cells["habilitadoDataGridViewCheckBoxColumn"].Value;
                chkbx_Habilitado.Checked = activo;
                txb_Nombre.Text = row.Cells["nombreDataGridViewTextBoxColumn"].Value.ToString();
                txb_Apellido.Text = row.Cells["apellidoDataGridViewTextBoxColumn"].Value.ToString();
                txb_Correo.Text = row.Cells["correoDataGridViewTextBoxColumn"].Value.ToString();
                txb_idUsuario .Text = row.Cells["idUsuarioDataGridViewTextBoxColumn"].Value.ToString();
                cbox_Rol.Text = row.Cells["rolDataGridViewTextBoxColumn"].Value.ToString();
                txb_UsuarioLogin.Text = row.Cells["loginDataGridViewTextBoxColumn"].Value.ToString();
                txtb_Password.Text = row.Cells["contraseñaDataGridViewTextBoxColumn"].Value.ToString();
                txtb_confirmPass.Text = row.Cells["contraseñaDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Fn_varias funciones = new Fn_varias();
            funciones.Clear_TBox(this);

            deshabilitar_txbox(true);
            dgv_carga_vista.Enabled = true;
        }
        
        private void habilitar_txbox(bool enable)
        {
            txb_Correo.Enabled = true;
            txb_Apellido.Enabled = true;
            txb_Nombre.Enabled = true;
            txb_UsuarioLogin.Enabled = false;
            txtb_Password.Enabled = true;
            txtb_confirmPass.Enabled = true;
            cbox_Rol.Enabled = true;
            chkbx_Habilitado.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Guardar.Enabled = true;
            btn_Cancelar.Enabled = true;
            btn_Eliminar.Enabled = true;
            btn_Atras.Enabled = false;
            dgv_carga_vista.Enabled = false;
            

        }

        private void deshabilitar_txbox(bool enable)
        {
            txb_Correo.Enabled = false;
            txb_Apellido.Enabled = false;
            txb_Nombre.Enabled = false;
            txb_UsuarioLogin.Enabled = false;
            cbox_Rol.Enabled = false;
            chkbx_Habilitado.Enabled = false;
            txtb_Password.Enabled = false;
            txtb_confirmPass.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Cancelar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Editar.Enabled=true;
            btn_Atras.Enabled=true;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            int idusuario = Convert.ToInt32(txb_idUsuario.Text); ;
            string nombre = txb_Nombre.Text;
            string apellido = txb_Apellido.Text;
            string correo = txb_Correo.Text;
            string username = txb_UsuarioLogin.Text;
            string rol = cbox_Rol.Text;
            string password = txtb_Password.Text;
            string passconfirm = txtb_confirmPass.Text;
            bool estado = chkbx_Habilitado.Checked;

            string mensajeError;
           
            if (!Fn_varias.ValidarDatosUsuario(username, password, passconfirm, nombre, apellido, correo, out mensajeError))
            {
                MessageBox.Show(mensajeError);
                return;
            }

            Editar_Usuario editar = new Editar_Usuario();
            editar.editar_usuario(idusuario, nombre, apellido, correo, username, password, rol, estado, passconfirm);

            deshabilitar_txbox(true);
            this.rolTableAdapter.Fill(this.lab4_inventarioDataSet4.rol);
            this.view_usuarios2TableAdapter.Fill(this.lab4_inventarioDataSet3.view_usuarios2);
            MessageBox.Show("Datos editados exitosamente");            
        }   

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            habilitar_txbox(true);
        }

        /*private void CargarDatos()
        {
            try
            {
                // Actualiza la tabla 'rol'
                this.rolTableAdapter.Fill(this.lab4_inventarioDataSet4.rol);
                // Actualiza la tabla 'view_usuarios2'
                this.view_usuarios2TableAdapter.Fill(this.lab4_inventarioDataSet3.view_usuarios2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
        */
    }
}
    