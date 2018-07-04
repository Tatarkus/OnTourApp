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
    public partial class Modificar_Noticia : Form
    {
        public Modificar_Noticia()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrar_Noticia noticia = new Administrar_Noticia();
            noticia.Show();
            this.Hide();
        }
    }
}
