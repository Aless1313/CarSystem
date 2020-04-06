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
using Tulpep.NotificationWindow;

namespace Car_System
{
    public partial class FormMenuAutosAgregar : Form
    {
        int num_cliente;
        string nombre;
        public FormMenuAutosAgregar(int id,string nom)
        {
            InitializeComponent();
            num_cliente = id;
            nombre = nom;
            lblPropietario.Text += nom;
            Alinear_label();            
        }

        public void Alinear_label()
        {
            int ancho, div;
            ancho = lblPropietario.Size.Width;
            div = 261 - (ancho / 2);
            lblPropietario.Location = new Point(div, 70);
        }

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
        private void Solo_numeros_y_letras_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtMar.Text.Trim() == "" || txtMod.Text.Trim() == "" || txtMat.Text.Trim() == "")
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "Llenar los campos";
                popupNotifier1.Popup();

                asterisco1.Visible = true;
                asterisco2.Visible = true;
                asterisco3.Visible = true;

                return;
            }

            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlCommand com = new MySqlCommand("INSERT INTO `autos`(`id_auto`, `id_cliente`, `marca`, `modelo`, `color`, `mat`, `vin`) VALUES (NULL,"+num_cliente+",'"+txtMar.Text+ "','"+txtMod.Text+ "','"+txtCol.Text+ "','"+txtMat.Text+ "','"+txtVIN.Text+"')", con);
            int resu = com.ExecuteNonQuery();
            if (resu>0)
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "Se agrego automovil a "+nombre+"";
                popupNotifier1.Popup();

                con.Close();

                this.Close();
            }
            else
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "No se agrego automovil";
                popupNotifier1.Popup();
                con.Close();
            }
            
        }
    }
}
