﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenieria_Software.EjecutivoUI
{
    public partial class Crear_Curso : Form
    {
        public Crear_Curso()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ADministrar_Cliente_Colegio_Ejecutivo aDministrar = new ADministrar_Cliente_Colegio_Ejecutivo();
            aDministrar.Show();
            this.Hide();
        }
    }
}
