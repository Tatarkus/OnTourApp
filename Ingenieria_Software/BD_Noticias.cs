﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenieria_Software
{
    public partial class BD_Noticias : Form
    {
        public BD_Noticias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Base_de_Datos datos = new Base_de_Datos();
            datos.Show();
            this.Hide();
        }
    }
}
