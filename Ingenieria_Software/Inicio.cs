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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administrar_Viaje viaje = new Administrar_Viaje();
            viaje.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrar_Seguro seguro = new Administrar_Seguro();
            seguro.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Administrar_Contrato contrato = new Administrar_Contrato();
            contrato.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Administrar_Noticia noticia = new Administrar_Noticia();
            noticia.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Base_de_Datos datos = new Base_de_Datos();
            datos.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
