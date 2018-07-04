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
    public partial class Modificar_Seguro : Form
    {
        public Modificar_Seguro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrar_Seguro seguro = new Administrar_Seguro();
            seguro.Show();
            this.Hide();
        }
    }
}
