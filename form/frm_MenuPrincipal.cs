using Lab4_inventario.cs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab4_inventario.frm_login;

namespace Lab4_inventario.form
{
    public partial class frm_MenuPrincipal : Form
    {
        //public frm_MenuPrincipal(user_login Usr_lgn)
        public frm_MenuPrincipal()
        {
            InitializeComponent();
            lb_usuario.Text = frm_login.nombre_user_login;
            lb_rol.Text = Convert.ToString(frm_login.id_rol);// esto lo puedo ocultar por seguridad by=oc
            lb_idsesion.Text = Convert.ToString(frm_login.id_sesion_g);
        }

        private void btn_salida_Click(object sender, EventArgs e)
        {
            frm_Salidas salidas = new frm_Salidas();

            // Mostrar el segundo formulario
            salidas.Show();
            this.Hide();
        }

        private void brn_CerrrarSesion_Click(object sender, EventArgs e)
        {

            // hay que hace que funcione el cierre de sesion con los cambios generados
            nombre_user_login = ""; 
            Menu_principal menu_Principal = new Menu_principal();
            
            menu_Principal.cerrar_sesion();
            
            frm_login login = new frm_login();
            login.Show();

            // Mostrar el segundo formulario
            this.Hide();
        }

        private void btn_Entrada_Click(object sender, EventArgs e)
        {
            frm_Entradas entradas = new frm_Entradas();

            // Mostrar el segundo formulario
            entradas.Show();
            this.Hide();
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            frm_Inventario inventario = new frm_Inventario();

            // Mostrar el segundo formulario
            inventario.Show();
            this.Hide();
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            frm_Reportes reportes = new frm_Reportes();

            // Mostrar el segundo formulario
            reportes.Show();
            this.Hide();
        }

        private void btn_Configuracion_Click(object sender, EventArgs e)
        {
            frm_Configuracion configuracion = new frm_Configuracion();

            // Mostrar el segundo formulario
            configuracion.Show();
            this.Hide();
        }

        private void frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            switch (id_rol)
            {
                case 1: //administrador
                    brn_CerrrarSesion.Enabled = true;
                    btn_Configuracion.Enabled = true;
                    btn_salida.Enabled = true;
                    btn_Entrada.Enabled = true;
                    btn_Inventario.Enabled = true;
                    btn_Reportes.Enabled = true;

                    break;
                case 2://jefe
                    brn_CerrrarSesion.Enabled = true;
                    btn_Configuracion.Enabled = false;
                    btn_salida.Enabled = true;
                    btn_Entrada.Enabled = true;
                    btn_Inventario.Enabled = true;
                    btn_Reportes.Enabled = true;

                    break;
                case 3://entradas
                    brn_CerrrarSesion.Enabled = true;
                    btn_Configuracion.Enabled = false;
                    btn_salida.Enabled = false;
                    btn_Entrada.Enabled = true;
                    btn_Inventario.Enabled = false;
                    btn_Reportes.Enabled = true;
                    break;
                case 4: // salidas
                    brn_CerrrarSesion.Enabled = true;
                    btn_Configuracion.Enabled = false;
                    btn_salida.Enabled = true;
                    btn_Entrada.Enabled = false;
                    btn_Inventario.Enabled = false;
                    btn_Reportes.Enabled = true;
                    break;
                case 5: //auditoria
                    brn_CerrrarSesion.Enabled = true;
                    btn_Configuracion.Enabled = false;
                    btn_salida.Enabled = false;
                    btn_Entrada.Enabled = false;
                    btn_Inventario.Enabled = false;
                    btn_Reportes.Enabled = true;
                    break;
                case 6://acceso a cardex
                    brn_CerrrarSesion.Enabled = true;
                    btn_Configuracion.Enabled = false;
                    btn_salida.Enabled = false;
                    btn_Entrada.Enabled = false;
                    btn_Inventario.Enabled = true;
                    btn_Reportes.Enabled = true;
                    break;
                case 7://entradas y salidas
                    brn_CerrrarSesion.Enabled = true;
                    btn_Configuracion.Enabled = false;
                    btn_salida.Enabled = true;
                    btn_Entrada.Enabled = true;
                    btn_Inventario.Enabled = false;
                    btn_Reportes.Enabled = true;
                    break;
                case 8: //ningun permiso
                    brn_CerrrarSesion.Enabled = true;
                    btn_Configuracion.Enabled = true;
                    btn_salida.Enabled = true;
                    btn_Entrada.Enabled = true;
                    btn_Inventario.Enabled = true;
                    btn_Reportes.Enabled = true;
                    break;
                default:
                    // lblResultado.Text = "Opción no válida.";
                    break;
            }
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            frm_GestionProveedores GProveedores = new frm_GestionProveedores();

            // Mostrar el segundo formulario
            GProveedores.Show();
            this.Hide();

        }
    }
}