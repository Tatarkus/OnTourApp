using System;
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
    public partial class Administrar_Seguro : Form
    {
        public Administrar_Seguro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crear_Seguro seguro = new Crear_Seguro();
            seguro.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modificar_Seguro seguro = new Modificar_Seguro();
            seguro.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
    }
}
