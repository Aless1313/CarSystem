﻿using System;
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
    public partial class FormMenuInventario : Form
    {
        public FormMenuInventario()
        {
            InitializeComponent();
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
        }

        private void btnEditarpieza_Click(object sender, EventArgs e)
        {
            Form agr = new FormMenuInventarioEditar();
            agr.ShowDialog();
        }
    }
}