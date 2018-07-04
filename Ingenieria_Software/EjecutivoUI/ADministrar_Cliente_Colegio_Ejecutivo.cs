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
   

    public partial class ADministrar_Cliente_Colegio_Ejecutivo : Form
    {
        

        public ADministrar_Cliente_Colegio_Ejecutivo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crear_Apoderado crear = new Crear_Apoderado();
            crear.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Modificar_Apoderado modificar = new Modificar_Apoderado();
            modificar.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Crear_Alumno crear = new Crear_Alumno();
            crear.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modificar_Alumno modificar = new Modificar_Alumno();
            modificar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Crear_Colegio crear = new Crear_Colegio();
            crear.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Modificar_Colegio modificar = new Modificar_Colegio();
            modificar.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Crear_Curso crear = new Crear_Curso();
            crear.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Modificar_Curso curso = new Modificar_Curso();
            curso.Show();
            this.Hide();
        }

       
    }
}
