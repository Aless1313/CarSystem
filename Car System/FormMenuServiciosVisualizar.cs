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
using System.Globalization;

namespace Car_System
{
    public partial class FormMenuServiciosVisualizar : Form
    {
        public FormMenuServiciosVisualizar(int id_servicio)
        {
            double sum_piezas = 0;
            double cost_servicio = 0;
            double cost_total = 0;
            int cont = 0;

            InitializeComponent();
            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlCommand com = new MySqlCommand("SELECT servicios.id_servicio , concat(clientes.nom,' ',clientes.ap,' ',clientes.am) as 'Nombre' ,concat(autos.marca,' ',autos.modelo,' ',autos.mat) as 'Automovil',servicios.desc_servicio,servicios.trabajador,servicios.costo as 'Costo'  FROM servicios INNER JOIN clientes ON servicios.id_cliente = clientes.id_cliente INNER JOIN autos ON servicios.id_auto = autos.id_auto  WHERE id_servicio = " + id_servicio+"", con);
            MySqlDataReader dr = com.ExecuteReader();
            dr.Read();

            lblCliente.Text = dr.GetString(1);
            lblAuto.Text = dr.GetString(2);
            lblDesc.Text = dr.GetString(3);
            lblTrabajador.Text = dr.GetString(4);
            lblCosto_Total.Text = dr.GetDouble(5).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            cost_total = dr.GetDouble(5);
            dr.Close();

            con.Close();

            MySqlConnection con1 = Conexion.Obtener_Conexion();
            MySqlCommand com1 = new MySqlCommand("SELECT piezas_servicio.pieza AS 'Pieza',piezas_servicio.cant_usada AS 'Cantidad usada',piezas_servicio.costo_u_pieza AS 'Costo/u',piezas_servicio.total_cost_piezas AS 'Total de piezas' FROM `piezas_servicio` WHERE id_servicio = " + id_servicio + "", con1);
            MySqlDataAdapter m_datos = new MySqlDataAdapter(com1);
            DataSet ds = new DataSet();
            m_datos.Fill(ds);
            dgvPiezas.DataSource = ds.Tables[0];

            con1.Close();

            
            foreach (DataGridViewRow row in dgvPiezas.Rows)
            {
                sum_piezas += Double.Parse(row.Cells[3].Value.ToString());
                cont++;
            }
            cost_servicio = cost_total - sum_piezas;

            lblCosto_Piezas.Text = sum_piezas.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            lblCosto_Servicio.Text = cost_servicio.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            lblCosto_Total.Text = cost_total.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));



        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
