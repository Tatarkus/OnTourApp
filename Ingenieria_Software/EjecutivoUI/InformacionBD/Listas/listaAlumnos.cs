using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenieria_Software.EjecutivoUI.InformacionBD.Listas
{
    public partial class listaAlumnos : UserControl
    {
        public listaAlumnos()
        {
            InitializeComponent();
            aLUMNOTableAdapter.Fill(this.dataSet1.ALUMNO);

        }

        private void dgAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            return ;
        }
    }
}
