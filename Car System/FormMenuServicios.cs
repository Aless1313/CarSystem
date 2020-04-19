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
    public partial class FormMenuServicios : Form
    {
        public FormMenuServicios()
        {
            InitializeComponent();
            Refrescar_y_cargar_datagrid();
        }
        public void Refrescar_y_cargar_datagrid()
        {
            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlCommand com = new MySqlCommand("SELECT servicios.id_servicio , concat(clientes.nom,' ',clientes.ap,' ',clientes.am) as 'Nombre' ,concat(autos.marca,' ',autos.modelo,' ',autos.mat) as 'Automovil',servicios.costo as 'Costo' FROM servicios  INNER JOIN clientes ON servicios.id_cliente = clientes.id_cliente INNER JOIN autos ON servicios.id_auto = autos.id_auto ", con);
            MySqlDataAdapter m_datos = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();
            m_datos.Fill(ds);
            dgvServicios.DataSource = ds.Tables[0];
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvServicios.CurrentCell = null;
                foreach (DataGridViewRow r in dgvServicios.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvServicios.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtBuscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {

                Refrescar_y_cargar_datagrid();
            }
        }

        private void btnNuevoServicio_Click(object sender, EventArgs e)
        {
            Form Agregar = new FormMenuServiciosAgregar();
            Agregar.ShowDialog();
            Refrescar_y_cargar_datagrid();
        
        }
    }
}
