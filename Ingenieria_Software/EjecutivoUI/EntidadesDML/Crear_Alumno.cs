using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ingenieria_Software.EjecutivoUI.InformacionBD.Listas;

namespace Ingenieria_Software.EjecutivoUI
{
    public partial class Crear_Alumno : Form
    {
        public Crear_Alumno()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ADministrar_Cliente_Colegio_Ejecutivo aDministrar = new ADministrar_Cliente_Colegio_Ejecutivo();
            aDministrar.Show();
            this.Hide();
        }

        private void Crear_Alumno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.ALUMNO' table. You can move, or remove it, as needed.
            this.aLUMNOTableAdapter.Fill(this.dataSet2.ALUMNO);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.aLUMNOTableAdapter.FillBy(this.dataSet2.ALUMNO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscaApoderado ba = new BuscaApoderado();
            ba.ShowDialog();
            this.txtApoRun.Text = ba.eleccion;
            ba.Close();
            
        }
    }
}
