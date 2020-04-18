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
    public partial class FormMenuServiciosAgregar : Form
    {
        int id_cliente = 0;
        int id_auto = 0;

        double[,] Piezas_usadas = new double[4,100];//[[id_piezas],[precio_unitario],[cantidad_en_existencia],[cantidad_usada]]
        double[] Costos_piezas = new double[100];


        public FormMenuServiciosAgregar()
        {
            InitializeComponent();
            Refrescar_y_cargar_datagrid_Clientes();

        }

        //Llenar los datagrid
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
        public void Refrescar_y_cargar_datagrid_Autos()
        {
            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlDataAdapter com = new MySqlDataAdapter("SELECT concat(clientes.nom,' ',clientes.ap,' ',clientes.am) as 'Propietario',id_auto as 'N° de automovil',CONCAT( autos.marca,' , ',autos.modelo) as 'Automovil',autos.color as 'Color',autos.mat as 'Matricula',autos.vin as 'VIN' FROM clientes INNER JOIN autos ON clientes.id_cliente = autos.id_cliente where autos.id_cliente = "+id_cliente+"", con);
            DataTable dt = new DataTable();
            com.Fill(dt);

            foreach (DataRow cc in dt.Rows)
            {
                int n = dgvAutos.Rows.Add();

                dgvAutos.Rows[n].Cells[0].Value = false;
                dgvAutos.Rows[n].Cells[1].Value = cc[0].ToString();
                dgvAutos.Rows[n].Cells[2].Value = cc[1].ToString();
                dgvAutos.Rows[n].Cells[3].Value = cc[2].ToString();
                dgvAutos.Rows[n].Cells[4].Value = cc[3].ToString();
                dgvAutos.Rows[n].Cells[5].Value = cc[4].ToString();
                dgvAutos.Rows[n].Cells[6].Value = cc[5].ToString();

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
            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                if (bool.Parse(row.Cells[0].Value.ToString()))
                {
                    id_cliente = Int32.Parse(row.Cells[1].Value.ToString());
                    cont++;
                }
            }
            if (cont != 0)
            {
                if (cont == 1)
                {
                    ck2.Checked = true;
                    xuiFlatTab1.SelectTab(1);
                    Refrescar_y_cargar_datagrid_Autos();
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
            int cont = 0;
            foreach (DataGridViewRow row in dgvAutos.Rows)
            {
                if (bool.Parse(row.Cells[0].Value.ToString()))
                {
                    id_auto = Int32.Parse(row.Cells[2].Value.ToString());
                    cont++;
                }
            }
            if (cont != 0)
            {
                if (cont == 1)
                {
                    ck3.Checked = true;
                    xuiFlatTab1.SelectTab(2);
                    Refrescar_y_cargar_datagrid_Inventario();
                    
                }
                else
                {
                    PopupNotifier popup = new PopupNotifier();
                    popupNotifier1.Image = Properties.Resources.info;
                    popupNotifier1.TitleText = "Automotriz Castillo";
                    popupNotifier1.ContentText = "Debe de elegir solo un automovil";
                    popupNotifier1.Popup();
                }
            }
            else
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "Debe de elegir un automovil";
                popupNotifier1.Popup();
            }

        }
        //Boton Siguiente 3
        private void btnSig3_Click(object sender, EventArgs e)
        {
            int cont = 0;
            foreach (DataGridViewRow row in dgvInventario.Rows)
            {
                if (bool.Parse(row.Cells[0].Value.ToString()))
                {
                    try
                    {
                        Int32.Parse(row.Cells[6].Value.ToString());
                    }
                    catch
                    {
                        PopupNotifier popup = new PopupNotifier();
                        popupNotifier1.Image = Properties.Resources.info;
                        popupNotifier1.TitleText = "Automotriz Castillo";
                        popupNotifier1.ContentText = "Cantidad no valida en la columna 'Cantidad Usada'";
                        popupNotifier1.Popup();
                        return;
                    }

                    if(Int32.Parse(row.Cells[6].Value.ToString())>0)
                    {
                        if(Int32.Parse(row.Cells[5].Value.ToString()) >= Int32.Parse(row.Cells[6].Value.ToString()))
                        {
                            Piezas_usadas[0, cont] = double.Parse(row.Cells[1].Value.ToString());
                            Piezas_usadas[1, cont] = double.Parse(row.Cells[4].Value.ToString());
                            Piezas_usadas[2, cont] = double.Parse(row.Cells[5].Value.ToString());
                            Piezas_usadas[2, cont] = double.Parse(row.Cells[6].Value.ToString());
                            cont++;

                        }
                        else
                        {
                            PopupNotifier popup = new PopupNotifier();
                            popupNotifier1.Image = Properties.Resources.info;
                            popupNotifier1.TitleText = "Automotriz Castillo";
                            popupNotifier1.ContentText = "La cantidad del apartado 'Cantidad Usada' no debe de exceder la cantidad del apartado 'Cantidad en existencia'";
                            popupNotifier1.Popup();
                            return;
                        }
                    }
                    else
                    {
                        PopupNotifier popup = new PopupNotifier();
                        popupNotifier1.Image = Properties.Resources.info;
                        popupNotifier1.TitleText = "Automotriz Castillo";
                        popupNotifier1.ContentText = "Las cantidades ingresadas en el apartado 'Cantidad Usada' deben de ser mayores a 0";
                        popupNotifier1.Popup();
                        return;
                    }


                    
                }
            }
            if (cont != 0)
            {
                ck4.Checked = true;
                xuiFlatTab1.SelectTab(3);
                for (int x = 0; x < 6; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        txtDesc.Text += Piezas_usadas[y,x].ToString()+"|";
                    }
                    txtDesc.Text += "°";
                }
            }
            else
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "Debe de elegir almenos una pieza";
                popupNotifier1.Popup();
            }
        }

    }
}
