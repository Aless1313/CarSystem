using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Tulpep.NotificationWindow;

namespace Car_System
{
    public partial class FormMenuAutosEditar : Form
    {
        int num_auto;
        public FormMenuAutosEditar(int id, string propietario,string[] datos)
        {
            InitializeComponent();
            num_auto = id;
            lblPropietario.Text += propietario;
            Alinear_label();

            txtMar.Text = datos[0];
            txtMod.Text = datos[1];
            txtCol.Text = datos[2];
            txtMat.Text = datos[3];
            txtVIN.Text = datos[4];
        }
        public void Alinear_label()
        {
            int ancho, div;
            ancho = lblPropietario.Size.Width;
            div = 261 - (ancho / 2);
            lblPropietario.Location = new Point(div, 70);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlCommand com = new MySqlCommand("UPDATE `autos` SET `marca`='"+txtMar.Text+ "',`modelo`='"+txtMod.Text+ "',`color`='"+txtCol.Text+ "',`mat`='"+txtMat.Text+ "',`vin`='"+txtVIN.Text+"' WHERE id_auto = "+ num_auto + "", con);
            int resu = com.ExecuteNonQuery();
            con.Close();
            if(resu>0)
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "Se guardaron los cambios";
                popupNotifier1.Popup();

                this.Close();
            }
            else
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "No se guardaron los cambios";
                popupNotifier1.Popup();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lparam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        
        }
    }
}
