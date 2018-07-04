using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software
{
    class Buzon
    {
        private Mensaje[] mensajes;
        public Buzon(Mensaje[] mensajes)
        {
            this.mensajes = mensajes;
        }
        public void setMensaje(Mensaje[] mensajes)
        {
            this.mensajes = mensajes;
        }
        public Mensaje[] getMensajes()
        {
            return mensajes;
        }
        
    }
}
