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
    public partial class BClientes : Form
    {
        public BClientes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Base_de_Datos datos = new Base_de_Datos();
            datos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BD_Apoderado apoderado = new BD_Apoderado();
            apoderado.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BD_Alumno alumno = new BD_Alumno();
            alumno.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BD_Colegio colegio = new BD_Colegio();
            colegio.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BD_Curso curso = new BD_Curso();
            curso.Show();
            this.Hide();
        }
    }
}
