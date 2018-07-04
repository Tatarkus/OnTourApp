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
    public partial class Modificar_Viaje : Form
    {
        public Modificar_Viaje()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrar_Viaje viaje = new Administrar_Viaje();
            viaje.Show();
            this.Hide();
        }
    }
}
