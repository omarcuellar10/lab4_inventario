using Lab4_inventario.form;
using Lab4_inventario.reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_inventario
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_login());
             //Application.Run(new frm_RegistroUsuarios());
            //Application.Run(new frm_Configuracion ());
           // Application.Run(new frm_ReporteSesiones());

        }
    }
}
