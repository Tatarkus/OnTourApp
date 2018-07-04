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
    public partial class Crear_Contrato : Form
    {
        public Crear_Contrato()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Creación de Contrato Exitoso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrar_Contrato contrato = new Administrar_Contrato();
            contrato.Show();
            this.Hide();
        }
    }
}
