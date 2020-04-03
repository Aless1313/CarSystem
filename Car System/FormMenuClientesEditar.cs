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
    public partial class FormMenuClientesEditar : Form
    {
        int num_cliente;
        public FormMenuClientesEditar(int ide,string[] datos)
        {
            InitializeComponent();
            num_cliente = ide;
            txtNom.Text = datos[0];
            txtAp.Text = datos[1];
            txtAm.Text = datos[2];
            txtTel.Text = datos[3];
            txtCorreo.Text = datos[4];
            txtRFC.Text = datos[5];

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Trim() == "" || txtAp.Text.Trim() == "" || txtAm.Text.Trim() == "" || txtTel.Text.Trim() == "")
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
            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlCommand com = new MySqlCommand("UPDATE `clientes` SET `nom`='"+txtNom.Text+ "',`ap`='"+txtAp.Text+ "',`am`='"+txtAm.Text+ "',`tel`='"+txtTel.Text+ "',`correo`='"+txtCorreo.Text+ "',`rfc`='"+txtRFC.Text+ "' WHERE id_cliente = "+num_cliente+"", con);
            int res = com.ExecuteNonQuery();
            if (res > 0)
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "Se edito al cliente";
                popupNotifier1.Popup();
                this.Close();
            }
            else
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "No pudo editar al cliente";
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
    }
}
