using System;
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
    public partial class Base_de_Datos : Form
    {
        public Base_de_Datos()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BD_Viajes viajes = new BD_Viajes();
            viajes.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BD_Seguros seguros = new BD_Seguros();
            seguros.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BD_Contratos contratos = new BD_Contratos();
            contratos.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BD_Noticias noticias = new BD_Noticias();
            noticias.Show();
            this.Hide();
        }



        private void button7_Click(object sender, EventArgs e)
        {
            BClientes clientes = new BClientes();
            clientes.Show();
            this.Hide();
        }
    }
}
