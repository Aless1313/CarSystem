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
            MySqlCommand com = new MySqlCommand("SELECT concat(clientes.nom,' ',clientes.ap) as 'Propietario',id_auto as 'N° de automovil',CONCAT( autos.marca,' , ',autos.modelo) as 'Automovil',autos.color as 'Color',autos.mat as 'Matricula',autos.vin as 'VIN' FROM clientes INNER JOIN autos ON clientes.id_cliente = autos.id_cliente", con);
            MySqlDataAdapter m_datos = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();
            m_datos.Fill(ds);
            dgvAutos.DataSource = ds.Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAutos.SelectedRows.Count == 1)
            {
                int id_auto = (int)dgvAutos.CurrentRow.Cells[1].Value;
                string propietario = (string)dgvAutos.CurrentRow.Cells[0].Value;
                string auto = (string)dgvAutos.CurrentRow.Cells[2].Value;
                string[] datos = new string[5];
                if (MessageBox.Show("¿Seguro que desea editar el automovil :" + auto + " del propietario :"+propietario+"?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection con = Conexion.Obtener_Conexion();
                    MySqlCommand com = new MySqlCommand("select * from autos where id_auto = "+id_auto+" ", con);
                    MySqlDataReader dr = com.ExecuteReader();
                    int contador = 0;
                    dr.Read();
                    while (contador <= 4)
                    {
                        datos[contador] = dr.GetString(contador + 2);
                        contador++;
                    }
                    con.Close();
                    Form Editar = new FormMenuAutosEditar(id_auto,propietario ,datos);
                    Editar.ShowDialog();
                    Refrescar_y_cargar_datagrid();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAutos.SelectedRows.Count == 1)
            {
                string propietario = (string)dgvAutos.CurrentRow.Cells[0].Value;
                
                string auto = (string)dgvAutos.CurrentRow.Cells[2].Value;
                
                if (MessageBox.Show("¿Seguro que desea eliminar el automovil  : " + auto + " del cliente : "+propietario+"?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id_auto = (int)dgvAutos.CurrentRow.Cells[1].Value;
                    MySqlConnection con = Conexion.Obtener_Conexion();
                    MySqlCommand com = new MySqlCommand("Delete From autos where id_auto = " + id_auto + "", con);
                    int Resultado = com.ExecuteNonQuery();
                    if (Resultado > 0)
                    {
                        PopupNotifier popup = new PopupNotifier();
                        popupNotifier1.Image = Properties.Resources.info;
                        popupNotifier1.TitleText = "Automotriz Castillo";
                        popupNotifier1.ContentText = "Se elimino el automovil";
                        popupNotifier1.Popup();
                        Refrescar_y_cargar_datagrid();
                    }
                    else
                    {
                        MessageBox.Show("No se Elimino");
                    }
                    con.Close();

                }


            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvAutos.CurrentCell = null;
                foreach (DataGridViewRow r in dgvAutos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvAutos.Rows)
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
    }
}
