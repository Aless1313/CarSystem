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
using Tulpep.NotificationWindow;

namespace Car_System
{
    public partial class FormMenuInventarioAgregar : Form
    {
        public FormMenuInventarioAgregar()
        {
            InitializeComponent();
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

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            PopupNotifier popupNotifier1 = new PopupNotifier();
            popupNotifier1.Image = Properties.Resources.info;
            popupNotifier1.TitleText = "Automotriz Castillo";
            popupNotifier1.ContentText = "No esta permitido el uso de comandos";
            popupNotifier1.Popup();
        }
    }
}
