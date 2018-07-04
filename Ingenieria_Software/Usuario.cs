using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software
{
    class Usuario
    {
        private String nombre_usuario;
        private String password;
        private int tipo_usuario;
        private DateTime termino_sesion;
        public Usuario(String nombre_usuario, String password, int tipo_usuario,DateTime termino_sesion)
        {
            this.nombre_usuario = nombre_usuario;
            this.password = password;
            this.tipo_usuario = tipo_usuario;
            this.termino_sesion = termino_sesion;
        
        }
        //set
        public void setNombreUsuario(String nombre_usuario)
        {
            this.nombre_usuario = nombre_usuario;
        }
        public void setPassword(String password)
        {
            this.password = password;
        }
        public void setUsuario(int tipo_usuario)
        {
            this.tipo_usuario = tipo_usuario;
        }
        public void setTerminoSesion(DateTime termino_sesion)
        {
            this.termino_sesion = termino_sesion;
        }
        //get
        public String getNombreUsuario()
        {
            return nombre_usuario;
        }
        public String getPassword()
        {
            return password;
        }
        public int getTipoUsuario()
        {
            return tipo_usuario;
        }
        public DateTime getTerminoSesion()
        {
            return termino_sesion;
        }
    }
}
