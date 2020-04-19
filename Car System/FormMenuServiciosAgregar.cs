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
        int id_servicio = 0;
        int id_cliente = 0;
        string cliente = "";
        int id_auto = 0;
        string auto = "";

        int cont = 0;

        double Monton = 0;
        double costo_total = 0;

        double[,] Piezas_usadas = new double[4,100];//[[id_piezas],[precio_unitario],[cantidad_en_existencia],[cantidad_usada]]
        double[] Costos_piezas = new double[100];//[(precio_unitario)(cantidad_usada)]
        double suma_costo_piezas = 0;
        string[] Nom_piezas = new string[100];


        public FormMenuServiciosAgregar()
        {
            InitializeComponent();
            Refrescar_y_cargar_datagrid_Clientes_con_Autos();
        }

        //Llenar los datagrid
        //DGVCLiente_Autos
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
        //DGVInventario
        public void Refrescar_y_cargar_datagrid_Inventario()
        {
            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlDataAdapter com = new MySqlDataAdapter("SELECT `id_pieza` as 'N° de pieza', concat(`nom`,' , ',`mar`)as 'Pieza', `costu` as 'Precio unitario', `cant` as 'Cantidad' FROM `inventario` ", con);
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
                dgvInventario.Rows[n].Cells[5].Value = "";
            }
        }
        //DGVPiezas
        public void Refrescar_y_cargar_datagrid_Piezas()
        {
            for(int piezas = 0;piezas<cont;piezas++)
            {
                int fila = dgvPiezas.Rows.Add();

                dgvPiezas.Rows[fila].Cells[0].Value = Nom_piezas[piezas];
                dgvPiezas.Rows[fila].Cells[1].Value = Piezas_usadas[3, piezas];
                dgvPiezas.Rows[fila].Cells[2].Value = Piezas_usadas[1, piezas];
                dgvPiezas.Rows[fila].Cells[3].Value = Costos_piezas[piezas];
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
                    if(txtDesc.Text.Trim() != "" && txtTrabajador.Text.Trim() != "")
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
                        popupNotifier1.ContentText = "Debe de llenar todos los campos";
                        popupNotifier1.Popup();
                    }
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
            cont = 0;
            suma_costo_piezas = 0;
            foreach (DataGridViewRow row in dgvInventario.Rows)
            {
                if (bool.Parse(row.Cells[0].Value.ToString()))
                {
                    try
                    {
                        if (Int32.Parse(row.Cells[4].Value.ToString()) >= Int32.Parse(row.Cells[5].Value.ToString()))
                        {
                            Nom_piezas[cont] = row.Cells[2].Value.ToString();
                            Piezas_usadas[0, cont] = double.Parse(row.Cells[1].Value.ToString());
                            Piezas_usadas[1, cont] = double.Parse(row.Cells[3].Value.ToString());
                            Piezas_usadas[2, cont] = double.Parse(row.Cells[4].Value.ToString());
                            Piezas_usadas[3, cont] = double.Parse(row.Cells[5].Value.ToString());
                            cont++;
                        }
                        else
                        {
                            PopupNotifier popup = new PopupNotifier();
                            popupNotifier1.Image = Properties.Resources.info;
                            popupNotifier1.TitleText = "Automotriz Castillo";
                            popupNotifier1.ContentText = "La cantidad en el apartado 'Cant. Usada' no puede exceder el apartado 'Cant. en existencia'";
                            popupNotifier1.Popup();
                            return;
                        }
                    }
                    catch
                    {
                        if (row.Cells[5].Value.ToString() != "")
                        {
                            PopupNotifier popup = new PopupNotifier();
                            popupNotifier1.Image = Properties.Resources.info;
                            popupNotifier1.TitleText = "Automotriz Castillo";
                            popupNotifier1.ContentText = "Cantidad no valida en 'Cant. Usada'";
                            popupNotifier1.Popup();
                        }
                        return;
                    }
                }
            }
            if (cont > 0)
            {
                for (int x = 0; x < cont; x++)
                {
                    Costos_piezas[x] = Piezas_usadas[1, x] * Piezas_usadas[3, x];
                    suma_costo_piezas += Costos_piezas[x];
                }
                txtCosto_Piezas.Text = suma_costo_piezas.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            }

            if (Monton>0)
            {
                lblCliente.Text = cliente;
                lblAuto.Text = auto;
                lblDesc.Text = txtDesc.Text;
                lblTrabajador.Text = txtTrabajador.Text;

                lblCosto_Piezas.Text = suma_costo_piezas.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                lblCosto_Servicio.Text = txtCosto_Servicio.Text;
                lblCosto_Total.Text = txtCosto_Total.Text;

                ck3.Checked = true;
                xuiFlatTab1.SelectTab(2);

                Refrescar_y_cargar_datagrid_Piezas();
            }
            else
            {
                PopupNotifier popup = new PopupNotifier();
                popupNotifier1.Image = Properties.Resources.info;
                popupNotifier1.TitleText = "Automotriz Castillo";
                popupNotifier1.ContentText = "Cantidad no valida en 'Costo de servicio'";
                popupNotifier1.Popup();
            }
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
            cont = 0;
            suma_costo_piezas = 0;
            foreach (DataGridViewRow row in dgvInventario.Rows)
            {
                if (bool.Parse(row.Cells[0].Value.ToString()))
                {
                    try
                    {
                        if (Int32.Parse(row.Cells[4].Value.ToString()) >= Int32.Parse(row.Cells[5].Value.ToString()))
                        {
                            Nom_piezas[cont] = row.Cells[2].Value.ToString();
                            Piezas_usadas[0, cont] = double.Parse(row.Cells[1].Value.ToString());
                            Piezas_usadas[1, cont] = double.Parse(row.Cells[3].Value.ToString());
                            Piezas_usadas[2, cont] = double.Parse(row.Cells[4].Value.ToString());
                            Piezas_usadas[3, cont] = double.Parse(row.Cells[5].Value.ToString());
                            cont++;
                        }
                        else
                        {
                            PopupNotifier popup = new PopupNotifier();
                            popupNotifier1.Image = Properties.Resources.info;
                            popupNotifier1.TitleText = "Automotriz Castillo";
                            popupNotifier1.ContentText = "La cantidad en el apartado 'Cant. Usada' no puede exceder el apartado 'Cant. en existencia'";
                            popupNotifier1.Popup();
                            return;
                        }
                    }
                    catch
                    {
                        if (row.Cells[5].Value.ToString() !="")
                        {
                            PopupNotifier popup = new PopupNotifier();
                            popupNotifier1.Image = Properties.Resources.info;
                            popupNotifier1.TitleText = "Automotriz Castillo";
                            popupNotifier1.ContentText = "Cantidad no valida en 'Cant. Usada'";
                            popupNotifier1.Popup();
                        }
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
                txtCosto_Servicio.Text = "";
                txtCosto_Piezas.Text = suma_costo_piezas.ToString("C",CultureInfo.CreateSpecificCulture("en-US"));
   
            }
        }

        private void txtCosto_Servicio_Leave(object sender, EventArgs e)
        {
            costo_total = 0;
            if (txtCosto_Servicio.Text == string.Empty)
            {
                return;
            }
            else
            {
                try
                {
                    if (Convert.ToDouble(txtCosto_Servicio.Text) > 0)
                    {
                        Monton = Convert.ToDouble(txtCosto_Servicio.Text);
                        txtCosto_Servicio.Text = Monton.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                        costo_total = Monton + suma_costo_piezas;
                        txtCosto_Total.Text = costo_total.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                    }
                    else
                    {
                        PopupNotifier popup = new PopupNotifier();
                        popupNotifier1.Image = Properties.Resources.info;
                        popupNotifier1.TitleText = "Automotriz Castillo";
                        popupNotifier1.ContentText = "Cantidad no valida";
                        popupNotifier1.Popup();
                        return;
                    }
                }
                catch
                {
                    PopupNotifier popup = new PopupNotifier();
                    popupNotifier1.Image = Properties.Resources.info;
                    popupNotifier1.TitleText = "Automotriz Castillo";
                    popupNotifier1.ContentText = "Cantidad no valida";
                    popupNotifier1.Popup();
                    return;
                }

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Buscar_en_Inventario_y_calcular_suma();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Conexion.Obtener_Conexion();
            MySqlCommand com = new MySqlCommand("INSERT INTO `servicios` (`id_servicio`, `id_cliente`, `id_auto`, `desc_servicio`, `trabajador`, `costo`) VALUES (NULL, " + id_cliente + ", " + id_auto + ", '" + txtDesc.Text + "', '" + txtTrabajador.Text + "', " + costo_total + ");", con);
            int res = com.ExecuteNonQuery();
            con.Close();
            if (res > 0)
            {
                MySqlConnection con1 = Conexion.Obtener_Conexion();
                MySqlCommand com1 = new MySqlCommand("SELECT MAX(id_servicio) FROM servicios", con1);
                MySqlDataReader dr = com1.ExecuteReader();
                dr.Read();

                id_servicio = dr.GetInt32(0);

                dr.Close();
                con1.Close();

                foreach (DataGridViewRow row in dgvPiezas.Rows)
                {
                    int cant_usada; 
                    double costo_u_pieza, total_cost_piezas;
                    string pieza;


                    pieza = row.Cells[0].Value.ToString();
                    cant_usada = Int32.Parse(row.Cells[1].Value.ToString());
                    costo_u_pieza = Double.Parse(row.Cells[2].Value.ToString());
                    total_cost_piezas = Double.Parse(row.Cells[3].Value.ToString());

                    double.Parse(row.Cells[1].Value.ToString());

                    MySqlConnection con2 = Conexion.Obtener_Conexion();
                    MySqlCommand com2 = new MySqlCommand("INSERT INTO `piezas_servicio`(`id_piezas_usadas`, `id_servicio`, `pieza`, `cant_usada`, `costo_u_pieza`, `total_cost_piezas`) VALUES (NULL," + id_servicio + ",'"+pieza+"',"+cant_usada.ToString()+","+costo_u_pieza.ToString()+","+costo_total.ToString()+")", con2);
                    int res1 = com2.ExecuteNonQuery();
                    if(res1>0)
                    {
                        con2.Close();
                        MessageBox.Show("Se agrego");
                    }

                }
                    
                
            }
            con.Close();
            this.Close();
        }
    }
}
