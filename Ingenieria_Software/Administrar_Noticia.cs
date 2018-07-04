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
    public partial class Administrar_Noticia : Form
    {
        public Administrar_Noticia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crear_Noticia noticia = new Crear_Noticia();
            noticia.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modificar_Noticia noticia = new Modificar_Noticia();
            noticia.Show();
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
