using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ingenieria_Software.Entidades;

namespace Ingenieria_Software.EjecutivoUI
{
    public partial class BD_Apoderado : Form
    {
        public BD_Apoderado()
        {
            InitializeComponent();
            ControladorUI.PoblarLista(listaApoderados1.getLista(), ControladorEntidades.apoderados);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Base_de_Datos datos = new Base_de_Datos();
            datos.Show();
            this.Hide();
        }

        private void listaApoderados1_Load(object sender, EventArgs e)
        {
        }

        private void listaApoderados1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
