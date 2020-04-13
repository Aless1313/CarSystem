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

namespace Car_System
{
    public partial class FormMenuConfiguracion : Form
    {
        public FormMenuConfiguracion()
        {
            InitializeComponent();

            lblNom.Text = Datos_Usu.nomusu;
            lblConta.Text = "Telefono: "+Datos_Usu.tel + ", Correo Electronico: " + Datos_Usu.correo;
            lblUsu.Text = Datos_Usu.usu;

            int x = 1;
            string ast = "";
            while(x <= Datos_Usu.con.Length)
            {
                ast += "*";
                x++;
            }
            lblCon.Text = ast;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMenuConfiguracion_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }
    }
}
