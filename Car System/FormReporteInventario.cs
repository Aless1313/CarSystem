using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;
using System.Runtime.InteropServices;

namespace Car_System
{
    public partial class FormReporteInventario : Form
    {
        MySqlConnection con = Conexion.Obtener_Conexion();


        public FormReporteInventario()
        {
            InitializeComponent();
            MySqlConnection con = Conexion.Obtener_Conexion();
            reportcargar();
        }

        private void FormReporteInventario_Load(object sender, EventArgs e)
        {

            this.rptinventario.RefreshReport();
        }

       
        private void reportcargar()
        {
            string consulta = "select * from inventario";
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            ReportDataSource fuente;
            fuente = new ReportDataSource("inventario",ds.Tables[0]);

            rptinventario.LocalReport.DataSources.Clear();
            rptinventario.LocalReport.DataSources.Add(fuente);
            rptinventario.LocalReport.ReportEmbeddedResource="Car_System.reporteinventario.rdlc";

            rptinventario.LocalReport.Refresh();
            rptinventario.Refresh();
            rptinventario.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
