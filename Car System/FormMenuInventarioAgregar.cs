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
using MySql.Data.MySqlClient;

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
            PopupNotifier popup = new PopupNotifier();
            popupNotifier1.Image = Properties.Resources.info;
            popupNotifier1.TitleText = "Automotriz Castillo";
            popupNotifier1.ContentText = "No esta permitido el uso de comandos";
            popupNotifier1.Popup();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtNom.Text.Trim() == "" || txtMarca.Text.Trim() == "" ||txtCost.Text.Trim() == "" )
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "Llenar los campos";
                popupNotifier1.Popup();

                asterisco1.Visible = true;
                asterisco2.Visible = true;
                asterisco3.Visible = true;
                asterisco4.Visible = true;

                return;
            }
            double cant, cost;
            try
            {
                if( txtCant.Value>0 && Convert.ToDouble(txtCost.Text)>0)
                {
                    cant = Convert.ToInt32(txtCant.Value);
                    cost = Convert.ToDouble(txtCost.Text);
                }
                else
                {
                    PopupNotifier popup = new PopupNotifier();
                    popupNotifier1.Image = Properties.Resources.info;
                    popupNotifier1.TitleText = "Automotriz Castillo";
                    popupNotifier1.ContentText = "Error solo ingresar numeros en los apartados de Cantidad y Costo";
                    popupNotifier1.Popup();
                    return;
                }
            }
            catch
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "Error solo ingresar numeros en los apartados de Cantidad y Costo";
                popupNotifier1.Popup();
                return;
            }


            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlCommand com = new MySqlCommand("INSERT INTO `inventario`(`id_pieza`, `nom`, `mar`, `cant`, `cost/u`) VALUES (NULL,'"+txtNom.Text+ "','"+txtMarca.Text+ "',"+cant+ ","+cost+")", con);
            int resu = com.ExecuteNonQuery();
            if(resu>0)
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "Se agrego la pieza";
                popupNotifier1.Popup();

                asterisco1.Visible = false;
                asterisco2.Visible = false;
                asterisco3.Visible = false;
                asterisco4.Visible = false;

                txtNom.Text = "";
                txtMarca.Text = "";
                txtCant.Value = 0;
                txtCost.Text = "";
            }
            else
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "No se pudo agregar la pieza";
                popupNotifier1.Popup();
            }
            con.Close();
        }
        //Eventos para solo un tipo de dato en los textbox
        private void Solo_letras_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Solo_numeros_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Solo_precios_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void No_usar_comandos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "No esta permitido el uso de comandos";
                popupNotifier1.Popup();
            }
        }
    }
}
