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
    public partial class Administrar_Viaje : Form
    {
        public Administrar_Viaje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crear_Viaje viaje = new Crear_Viaje();
            viaje.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modificar_Viaje viaje = new Modificar_Viaje();
            viaje.Show();
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
