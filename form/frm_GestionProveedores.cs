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
    public partial class frm_GestionProveedores : Form
    {
        public frm_GestionProveedores()
        {
            InitializeComponent();
        }

        private void btn_AgregarProovedor_Click(object sender, EventArgs e)
        {
            
            frm_RegistroProveedor RegProveedor = new frm_RegistroProveedor();
            RegProveedor.Show();
            this.Hide();
        }
    }
}
