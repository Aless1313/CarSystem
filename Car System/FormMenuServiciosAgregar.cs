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
    public partial class FormMenuServiciosAgregar : Form
    {
        public FormMenuServiciosAgregar()
        {
            InitializeComponent();
            Refrescar_y_cargar_datagrid_Clientes();
        }
        public void Refrescar_y_cargar_datagrid_Clientes()
        {
            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlDataAdapter com = new MySqlDataAdapter("select id_cliente as 'N° de cliente',concat(nom,' ',ap,' ',am) as 'Nombre',tel as 'Telefono', correo as 'Correo Electronico',rfc as 'RFC' from clientes", con);
            DataTable dt = new DataTable();
            com.Fill(dt);

            foreach (DataRow cc in dt.Rows)
            {
                int n = dgvClientes.Rows.Add();

                dgvClientes.Rows[n].Cells[0].Value = false;
                dgvClientes.Rows[n].Cells[1].Value = cc[0].ToString();
                dgvClientes.Rows[n].Cells[2].Value = cc[1].ToString();
                dgvClientes.Rows[n].Cells[3].Value = cc[2].ToString();
                dgvClientes.Rows[n].Cells[4].Value = cc[3].ToString();
                dgvClientes.Rows[n].Cells[5].Value = cc[4].ToString();

            }


        }
        public void Refrescar_y_cargar_datagrid_Autos(string cliente)
        {
            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlCommand com = new MySqlCommand("SELECT concat(clientes.nom,' ',clientes.ap,' ',clientes.am) as 'Propietario',id_auto as 'N° de automovil',CONCAT( autos.marca,' , ',autos.modelo) as 'Automovil',autos.color as 'Color',autos.mat as 'Matricula',autos.vin as 'VIN' FROM clientes INNER JOIN autos ON clientes.id_cliente = autos.id_cliente", con);
            MySqlDataAdapter m_datos = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();
            m_datos.Fill(ds);
            dgvAutos.DataSource = ds.Tables[0];
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSig1_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvClientes.Rows)
            {
                    if (bool.Parse(row.Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Se selecciono un cliente");
                    }
            }
        }

        private void FormMenuServiciosAgregar_Load(object sender, EventArgs e)
        {
           
        }
    }
}
