using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software
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
        public void setContenido(String contenido)
        {
            this.contenido = contenido;
        }
        public void setDestinatarios(String[] destinatarios)
        {
            this.destinatarios = destinatarios;
        }
        public void setComprobante(Deposito d)
        {

            this.comprobante = d;
        }
        public String getContenido()
        {
            return contenido;
        }
        public String[] getDestinatarios()
        {
            return destinatarios;
        }
        public Deposito getComprobante()
        {
            return comprobante;
        }
    }
}
