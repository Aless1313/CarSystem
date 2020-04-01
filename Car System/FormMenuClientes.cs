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
    public partial class FormMenuClientes : Form
    {
        public FormMenuClientes()
        {
            InitializeComponent();

            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlCommand com = new MySqlCommand("select id_cliente as 'N° de cliente',concat(nom,' ',ap,' ',am) as 'Nombre',tel as 'Telefono', correo as 'Correo Electronico',rfc as 'RFC' from clientes", con);
            MySqlDataAdapter m_datos = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();
            m_datos.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

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
