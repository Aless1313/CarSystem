using MySql.Data.MySqlClient;
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
    public partial class FormMenuPersonal : Form
    {
        public void Refrescar_y_cargar_datagrid()
        {
            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlCommand com = new MySqlCommand("select id_usuario as 'N° de Empleado',nom_usu 'Nombre',usu as 'Usuario', tel as 'Telefono',correo as 'Correo Electronico', CASE rang WHEN '1' THEN 'Colaborador' WHEN '2' THEN 'Gerente' WHEN '3' THEN 'Dueño' WHEN '4' THEN 'Administrador' END as 'Rango' from usuarios", con);
            MySqlDataAdapter m_datos = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();
            m_datos.Fill(ds);
            dgvPersonal.DataSource = ds.Tables[0];
        }
        public FormMenuPersonal()
        {
            InitializeComponent();
            Refrescar_y_cargar_datagrid();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void btnEditarPriv_Click(object sender, EventArgs e)
        {
            Form editar_personal = new FormMenuPersonalEditarPrivilegios();
            editar_personal.ShowDialog();
            
        }*/

        private void btnAñadirPers_Click(object sender, EventArgs e)
        {
            Form agregar_personal = new FormMenuPersonalAgregar();
            agregar_personal.ShowDialog();
            
        }

        private void btnEditarPriv_Click_1(object sender, EventArgs e)
        {
            Form editar_personal = new FormMenuPersonalEditarPrivilegios();
            editar_personal.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvPersonal.CurrentCell = null;
                foreach (DataGridViewRow r in dgvPersonal.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvPersonal.Rows)
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
