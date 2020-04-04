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
    public partial class FormMenuClientes : Form
    {
        public void Refrescar_y_cargar_datagrid()
        {
            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlCommand com = new MySqlCommand("select id_cliente as 'N° de cliente',concat(nom,' ',ap,' ',am) as 'Nombre',tel as 'Telefono', correo as 'Correo Electronico',rfc as 'RFC' from clientes", con);
            MySqlDataAdapter m_datos = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();
            m_datos.Fill(ds);
            dgvClientes.DataSource = ds.Tables[0];
        }

        public FormMenuClientes()
        {
            InitializeComponent();
            Refrescar_y_cargar_datagrid();
        }
        //Al dar clic a cualquier botono
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form agr = new FormMenuClientesAgregar();
            agr.ShowDialog();
            Refrescar_y_cargar_datagrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                int id = (int)dgvClientes.CurrentRow.Cells[0].Value;
                string nom = (string)dgvClientes.CurrentRow.Cells[1].Value;
                string[] datos = new string[6];
                if (MessageBox.Show("¿Seguro que desea editar al Alumno :" + nom + "?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection con = Conexion.Obtener_Conexion();
                    MySqlCommand com = new MySqlCommand("select * from clientes where id_cliente = " + id + " ", con);
                    MySqlDataReader dr = com.ExecuteReader();
                    int contador = 0;
                    dr.Read();
                    while (contador <= 5)
                    {

                        datos[contador] = dr.GetString(contador+1);
                        contador++;
                    }
                    Form Editar = new FormMenuClientesEditar(id, datos);
                    Editar.ShowDialog();
                    Refrescar_y_cargar_datagrid();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                string nom = (string)dgvClientes.CurrentRow.Cells[1].Value;
                if (MessageBox.Show("¿Seguro que desea eliminar al Alumno :" + nom + "?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dgvClientes.CurrentRow.Cells[0].Value;
                    MySqlConnection con = Conexion.Obtener_Conexion();
                    MySqlCommand com = new MySqlCommand("Delete From clientes where id_cliente = " + id + "", con);
                    int Resultado = com.ExecuteNonQuery();
                    if (Resultado > 0)
                    {
                        PopupNotifier popup = new PopupNotifier();
                        popupNotifier1.Image = Properties.Resources.info;
                        popupNotifier1.TitleText = "Automotriz Castillo";
                        popupNotifier1.ContentText = "Se elimino al cliente";
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

        private void button1_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();
            popupNotifier1.Image = Properties.Resources.info;
            popupNotifier1.TitleText = "Automotriz Castillo";
            popupNotifier1.ContentText = "Seleccionar solo a un cliente";
            popupNotifier1.Popup();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "No esta permitido el uso de comandos";
                popupNotifier1.Popup();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
