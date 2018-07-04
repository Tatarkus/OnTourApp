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
    public partial class BD_Aporte : Form
    {
        public BD_Aporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Base_de_Datos datos = new Base_de_Datos();
            datos.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listaAportes1_Load(object sender, EventArgs e)
        {

        }
    }
}
