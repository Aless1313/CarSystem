using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_System
{
    public partial class FormMenuAutosAgregar : Form
    {
        int num_cliente;
        public FormMenuAutosAgregar(int id,string nom)
        {
            InitializeComponent();
            int ancho,div;
            num_cliente = id;
            lblPropietario.Text += nom;
            ancho = lblPropietario.Size.Width;
            div = (ancho / 2)-261;
            lblPropietario.Location.Offset(div,70);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
