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
using System.Globalization;

namespace Car_System
{
    public partial class FormMenuServiciosAgregar : Form
    {
        int id_cliente = 0;
        string cliente = "";
        int id_auto = 0;
        string auto = "";

        double[,] Piezas_usadas = new double[4,100];//[[id_piezas],[precio_unitario],[cantidad_en_existencia],[cantidad_usada]]
        double[] Costos_piezas = new double[100];//[(precio_unitario)(cantidad_usada)]
        double suma_costo_piezas = 0;


        public FormMenuServiciosAgregar()
        {
            InitializeComponent();
            Refrescar_y_cargar_datagrid_Clientes_con_Autos();
        }

        //Llenar los datagrid
       
        public void Refrescar_y_cargar_datagrid_Clientes_con_Autos()
        {
            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlDataAdapter com = new MySqlDataAdapter("SELECT clientes.id_cliente,concat(clientes.nom,' ',clientes.ap,' ',clientes.am) as 'Propietario',id_auto as 'N° de automovil',CONCAT( autos.marca,' , ',autos.modelo) as 'Automovil',autos.color as 'Color',autos.mat as 'Matricula',autos.vin as 'VIN' FROM clientes INNER JOIN autos ON clientes.id_cliente = autos.id_cliente", con);
            DataTable dt = new DataTable();
            com.Fill(dt);

            foreach (DataRow cc in dt.Rows)
            {
                int n = dgvClientes_Autos.Rows.Add();

                dgvClientes_Autos.Rows[n].Cells[0].Value = false;
                dgvClientes_Autos.Rows[n].Cells[1].Value = cc[0].ToString();
                dgvClientes_Autos.Rows[n].Cells[2].Value = cc[1].ToString();
                dgvClientes_Autos.Rows[n].Cells[3].Value = cc[2].ToString();
                dgvClientes_Autos.Rows[n].Cells[4].Value = cc[3].ToString();
                dgvClientes_Autos.Rows[n].Cells[5].Value = cc[4].ToString();
                dgvClientes_Autos.Rows[n].Cells[6].Value = cc[5].ToString();
                dgvClientes_Autos.Rows[n].Cells[7].Value = cc[6].ToString();


            }
        }

        public void Refrescar_y_cargar_datagrid_Inventario()
        {

            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlDataAdapter com = new MySqlDataAdapter("SELECT `id_pieza` as 'N° de pieza', `nom` as 'Pieza', `mar` as 'Marca', `costu` as 'Precio unitario', `cant` as 'Cantidad' FROM `inventario` ", con);
            DataTable dt = new DataTable();
            com.Fill(dt);

            foreach (DataRow cc in dt.Rows)
            {
                int n = dgvInventario.Rows.Add();

                dgvInventario.Rows[n].Cells[0].Value = false;
                dgvInventario.Rows[n].Cells[1].Value = cc[0].ToString();
                dgvInventario.Rows[n].Cells[2].Value = cc[1].ToString();
                dgvInventario.Rows[n].Cells[3].Value = cc[2].ToString();
                dgvInventario.Rows[n].Cells[4].Value = cc[3].ToString();
                dgvInventario.Rows[n].Cells[5].Value = cc[4].ToString();


            }

        }
        //



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void FormMenuServiciosAgregar_Load(object sender, EventArgs e)
        {
           
        }

        //Botones
        //Boton Siguiente 1
        private void btnSig1_Click(object sender, EventArgs e)
        {
            int cont = 0;
            foreach (DataGridViewRow row in dgvClientes_Autos.Rows)
            {
                if (bool.Parse(row.Cells[0].Value.ToString()))
                {
                    id_cliente = Int32.Parse(row.Cells[1].Value.ToString());
                    cliente = row.Cells[2].Value.ToString();
                    id_auto = Int32.Parse(row.Cells[3].Value.ToString());
                    auto = row.Cells[4].Value.ToString()+" , "+row.Cells[6].Value.ToString();
                    cont++;
                }
            }
            if (cont != 0)
            {
                if (cont == 1)
                {
                    ck2.Checked = true;
                    xuiFlatTab1.SelectTab(1);
                    Refrescar_y_cargar_datagrid_Inventario();

                }
                else
                {
                    PopupNotifier popup = new PopupNotifier();
                    popupNotifier1.Image = Properties.Resources.info;
                    popupNotifier1.TitleText = "Automotriz Castillo";
                    popupNotifier1.ContentText = "Debe de elegir solo un cliente";
                    popupNotifier1.Popup();
                }
            }
            else
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "Debe de elegir un cliente";
                popupNotifier1.Popup();
            }
        }
        
        //Boton Siguiente 2
        private void btnSig2_Click(object sender, EventArgs e)
        {
            txtCliente.Text = cliente;
            txtAuto.Text = auto;
            txtDescTrabajo.Text = txtDesc.Text;
            txtTrabajador1.Text = txtTrabajador.Text;

            txtCostoPiezas.Text = txtCosto_Piezas.Text;
            txtCostoServicio.Text = txtCosto_Servicio.Text;
            txtCostoTotal.Text = txtCosto_Total.Text;

            ck3.Checked = true;
            xuiFlatTab1.SelectTab(2);

        }


        private void Solo_precios_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void Buscar_en_Inventario_y_calcular_suma()
        {
            int cont = 0;
            suma_costo_piezas = 0;
            foreach (DataGridViewRow row in dgvInventario.Rows)
            {
                if (bool.Parse(row.Cells[0].Value.ToString()))
                {
                    try
                    {
                        if (Int32.Parse(row.Cells[5].Value.ToString()) >= Int32.Parse(row.Cells[6].Value.ToString()))
                        {
                            Piezas_usadas[0, cont] = double.Parse(row.Cells[1].Value.ToString());
                            Piezas_usadas[1, cont] = double.Parse(row.Cells[4].Value.ToString());
                            Piezas_usadas[2, cont] = double.Parse(row.Cells[5].Value.ToString());
                            Piezas_usadas[3, cont] = double.Parse(row.Cells[6].Value.ToString());
                            cont++;
                        }
                        else
                        {
                            return;
                        }
                    }
                    catch
                    {
                        return;
                    }

                    
                }
            }

            if(cont>0)
            {
                for(int x = 0; x<cont;x++)
                {
                    Costos_piezas[x] = Piezas_usadas[1, x] * Piezas_usadas[3, x];
                    suma_costo_piezas += Costos_piezas[x]; 
                }
                txtCosto_Piezas.Text = suma_costo_piezas.ToString("C",CultureInfo.CreateSpecificCulture("en-US"));
   
            }
        }





        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void dgvInventario_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Buscar_en_Inventario_y_calcular_suma();
        }

        private void txtCosto_Servicio_Leave(object sender, EventArgs e)
        {
            double costo_total = 0;
            if (txtCosto_Servicio.Text == string.Empty)
            {
                return;
            }
            else
            {
                try
                {
                    double Monton = 0;
                    Monton = Convert.ToDouble(txtCosto_Servicio.Text);
                    txtCosto_Servicio.Text = Monton.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                    costo_total = Monton + suma_costo_piezas;
                    txtCosto_Total.Text = costo_total.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                }
                catch
                {
                    return;
                }

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
