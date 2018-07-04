using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software.Entidades
{
    public abstract class EntidadesBD
    {
        private int id;
        public abstract List<String> ListaDatos();
    }

    
}
