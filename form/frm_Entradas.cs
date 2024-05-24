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
    public partial class frm_Entradas : Form
    {
        public frm_Entradas()
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
    }
}
