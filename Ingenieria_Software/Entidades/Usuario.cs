using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software.Entidades
{
    class Usuario
    {
        private String nombre_usuario;
        private String password;
        private int tipo_usuario;
        private DateTime termino_sesion;
        public Usuario(String nombre_usuario, String password, int tipo_usuario, DateTime termino_sesion)
        {
            this.nombre_usuario = nombre_usuario;
            this.password = password;
            this.tipo_usuario = tipo_usuario;
            this.termino_sesion = termino_sesion;
        }
        public String Nombre_usuario { get; set; }
        public String Password { get; set; }
        public int Tipo_usuario { get; set; }
        public DateTime Termino_sesion { get; set; }
        

    }
}
