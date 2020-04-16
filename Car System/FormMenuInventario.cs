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
    public partial class FormMenuInventario : Form
    {
        public void Refrescar_y_cargar_datagrid()
        {

            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlCommand com = new MySqlCommand("SELECT `id_pieza` as 'N° de pieza', concat(nom,' , ',mar) as 'Pieza', `cant` as 'Cantidad', `costu` as 'Precio unitario' FROM `inventario` ", con);
            MySqlDataAdapter m_datos = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();
            m_datos.Fill(ds);
            dgvInventario.DataSource = ds.Tables[0];
        }

        public FormMenuInventario()
        {
            InitializeComponent();
            Refrescar_y_cargar_datagrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarpieza_Click(object sender, EventArgs e)
        {
            Form agr = new FormMenuInventarioAgregar();
            agr.ShowDialog();
            Refrescar_y_cargar_datagrid();
        }

        private void btnEditarpieza_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count == 1)
            {
                int id = (int)dgvInventario.CurrentRow.Cells[0].Value;
                string nomb = (string)dgvInventario.CurrentRow.Cells[1].Value;
                string nom, mar;
                int cant;
                double prec;


                if (MessageBox.Show("¿Seguro que desea editar la pieza :" + nomb + "?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection con = Conexion.Obtener_Conexion();
                    MySqlCommand com = new MySqlCommand("select * from inventario where id_pieza = " + id + " ", con);
                    MySqlDataReader dr = com.ExecuteReader();
                    dr.Read();


                    nom = dr.GetString(1);
                    mar = dr.GetString(2);
                    cant = dr.GetInt32(3);
                    prec = Math.Round(dr.GetDouble(4), 2);


                    Form Editar = new FormMenuInventarioEditar(id, nom, mar, cant, prec);
                    Editar.ShowDialog();
                    Refrescar_y_cargar_datagrid();
                    con.Close();
                }
            }
        }

        private void btnEliminarpieza_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count == 1)
            {
                string nom = (string)dgvInventario.CurrentRow.Cells[1].Value;
                if (MessageBox.Show("¿Seguro que desea eliminar la pieza :" + nom + "?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dgvInventario.CurrentRow.Cells[0].Value;
                    MySqlConnection con = Conexion.Obtener_Conexion();
                    MySqlCommand com = new MySqlCommand("Delete From inventario where id_pieza = " + id + "", con);
                    int Resultado = com.ExecuteNonQuery();
                    if (Resultado > 0)
                    {
                        PopupNotifier popup = new PopupNotifier();
                        popupNotifier1.Image = Properties.Resources.info;
                        popupNotifier1.TitleText = "Automotriz Castillo";
                        popupNotifier1.ContentText = "Se elimino la pieza";
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

        private void btn_imprimirinv_Click(object sender, EventArgs e)
        {
            Form imp = new FormReporteInventario();
            imp.ShowDialog();
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvInventario.CurrentCell = null;
                foreach (DataGridViewRow r in dgvInventario.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvInventario.Rows)
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
