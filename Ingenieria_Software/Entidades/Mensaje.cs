using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software.Entidades
{
    class Mensaje
    {
        private String contenido;
        private String[] destinatarios;
        Deposito comprobante;
        public Mensaje(String contenido, String[] destinatarios, Deposito comprobante)
        {
            this.contenido = contenido;
            this.destinatarios = destinatarios;
            this.comprobante = comprobante;
        }
        public String Contenido { get; set; }
        public String[] Destinatarios { get; set; }
        public Deposito Comprobante { get; set; }
    }
}
