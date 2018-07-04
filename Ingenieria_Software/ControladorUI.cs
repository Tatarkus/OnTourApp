using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ingenieria_Software.Entidades;

namespace Ingenieria_Software
{
    public static class ControladorUI
    {


        public static void PoblarLista(ListView mi_lista, List<EntidadesBD> mis_entidades)
        {
            foreach (EntidadesBD entidad in mis_entidades)
            {
               
            mi_lista.Items.Add(new ListViewItem(entidad.ListaDatos().ToArray()));

            }
        }



    }
}
