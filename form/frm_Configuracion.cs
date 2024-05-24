using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_inventario.form
{
    public partial class frm_Configuracion : Form
    {
        public frm_Configuracion()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            frm_MenuPrincipal principal = new frm_MenuPrincipal();
            principal.Show();

            // Mostrar el segundo formulario
            this.Hide();
        }

        private void btn_agregarUsuario_Click(object sender, EventArgs e)
        {
            frm_RegistroUsuarios registro = new frm_RegistroUsuarios ();
            registro.Show();

            // Mostrar el segundo formulario
            this.Hide();
        }

        private void btn_EditarUsuario_Click(object sender, EventArgs e)
        {
            frm_EditarUsuario editar = new frm_EditarUsuario();
            editar.Show();

            // Mostrar el segundo formulario
            this.Hide();

        }
    }
}
