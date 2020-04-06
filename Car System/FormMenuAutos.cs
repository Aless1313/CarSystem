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
    public partial class FormMenuAutos : Form
    {
        public FormMenuAutos()
        {
            InitializeComponent();
            Refrescar_y_cargar_datagrid();
        }

        public void Refrescar_y_cargar_datagrid()
        {
            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlCommand com = new MySqlCommand("SELECT concat(clientes.nom,' ',clientes.ap,' ',clientes.am) as 'Propietario',CONCAT( autos.marca,' , ',autos.modelo) as 'Automovil',autos.color as 'Color',autos.mat as 'Matricula',autos.vin as 'VIN' FROM clientes LEFT JOIN autos ON clientes.id_cliente = autos.id_cliente", con);
            MySqlDataAdapter m_datos = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();
            m_datos.Fill(ds);
            dgvAutos.DataSource = ds.Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
