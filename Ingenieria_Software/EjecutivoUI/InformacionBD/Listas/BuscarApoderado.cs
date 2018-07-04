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


namespace Ingenieria_Software.EjecutivoUI.InformacionBD.Listas
{
    public partial class BuscaApoderado : Form
    {

        public string eleccion ="";
        public BuscaApoderado()
        {
            InitializeComponent();
            ControladorUI.PoblarLista(this.listaApoderados1.getLista(), ControladorEntidades.apoderados);
        }

        private void listaApoderados1_Load(object sender, EventArgs e)
        {

        }

        private void  btnAceptar_Click(object sender, EventArgs e)
        {
            if (listaApoderados1.getLista().SelectedItems.Count > 0)
            {
                this.Hide();
                eleccion = listaApoderados1.getLista().SelectedItems[0].SubItems[1].Text;           }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       

                foreach (ListViewItem fila in this.listaApoderados1.getLista().Items)
                {
                   
                        fila.Remove();
                }
            ControladorUI.PoblarLista(this.listaApoderados1.getLista(), ControladorEntidades.apoderados);



            if (this.tbBuscar.Text.Length > 0)
            {
                foreach (ListViewItem fila in this.listaApoderados1.getLista().Items)
                {
                    if (!fila.SubItems[1].Text.StartsWith(tbBuscar.Text))
                    {
                        fila.Remove();
                    }
                }
            }
        }
    }
}
