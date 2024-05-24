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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab4_inventario.form
{
    public partial class frm_RegistroProveedor : Form
    {
        public frm_RegistroProveedor()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            frm_GestionProveedores GProveedores = new frm_GestionProveedores();

            // Mostrar el segundo formulario
            GProveedores.Show();
            this.Hide();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string nombre = tx_NombreProveedor.Text;
            string nit = tx_Nit.Text;
            string categoria = cbox_categoria.Text; //tipo tecnologico, ferreteria, costura
            string ncr = tx_NCR.Text;
            string giro = tx_Giro.Text;
            string tipoContribuyente = tx_CategoriaDeContribuyente.Text;
            string pais = cbox_Pais.Text;
            string direccion = tx_Direccion.Text;
            string tel1 = tx_Tel1.Text;
            string tel2 = tx_Tel2.Text;
            string RepresentanteLegal = tx_NombreRepresentante.Text;
            string personaContacto = tx_PersonaDeContacto.Text;
            string correo = tx_CorreoProveedor.Text;
            DateTime fechareg = DateTime.Now;

            try
            {
                RegistroProveedor Reg_prov = new RegistroProveedor();
                Reg_prov.Insertar_Proveedor(nombre, nit, categoria, ncr, giro, tipoContribuyente,
                    pais, direccion, tel1, tel2, RepresentanteLegal, personaContacto, correo, fechareg);
                MessageBox.Show("proveedor guardado exitosamente.");

                Fn_varias fn_Varias = new Fn_varias();
                fn_Varias.Clear_TBox(this); // Llamar al método para limpiar los TextBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el usuario: " + ex.Message);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Fn_varias funciones = new Fn_varias();
            funciones.Clear_TBox(this);
        }

        private void frm_RegistroProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lab4_inventarioDataSet7.Paises' Puede moverla o quitarla según sea necesario.
            this.paisesTableAdapter.Fill(this.lab4_inventarioDataSet7.Paises);
            // TODO: esta línea de código carga datos en la tabla 'lab4_inventarioDataSet6.Categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.lab4_inventarioDataSet6.Categorias);

        }
    }
}
