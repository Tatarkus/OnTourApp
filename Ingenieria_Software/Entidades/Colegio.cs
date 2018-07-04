using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software.Entidades
{
    class Colegio
    {
        private int id_colegio;
        private String nombre;
        private String calle;
        private int numero;
        private String comuna;
        private int telefono;
        public Colegio(int id_colegio,String nombre, String calle, int numero, String comuna,int telefono)
        {
            this.id_colegio = id_colegio;
            this.nombre = nombre;
            this.calle = calle;
            this.numero = numero;
            this.comuna = comuna;
            this.telefono = telefono;
        }
        public int Id_colegio { get; set; }
        public String Nombre { get; set; }
        public String Calle { get; set; }
        public int Numero { get; set; }
        public String Comuna { get; set; }
        public int Telefono { get; set; }
    }
}
