﻿using Lab4_inventario.cs;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab4_inventario.reports
{
    public partial class frm_ReporteInventario : Form
    {
        public frm_ReporteInventario()
        {
            InitializeComponent();
        }

        private void frm_ReporteInventario_Load(object sender, EventArgs e)
        {

            
            this.reportViewer1.RefreshReport();

            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ObtenerConexion();
            string querySesion = "Select * from sesion2";// llama a la vista a la cual se le´puede hacer un filtro 
            SqlCommand cmd = new SqlCommand(querySesion, connection);
            SqlDataAdapter d = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("reportesesionview", dt);
            //string reportPath = Path.Combine(Application.StartupPath, "Report1.rdlc");
            //reportViewer1.LocalReport.ReportPath = reportPath;

            reportViewer1.LocalReport.ReportPath = "D:\\UFG progra 2024\\C1\\cc102921\\Lab4_inventario\\reports\\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
    }
}
