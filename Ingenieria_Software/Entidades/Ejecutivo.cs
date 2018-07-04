using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingenieria_Software.Entidades;
namespace Ingenieria_Software
{
    class Ejecutivo : EntidadesBD
    {
        private String run;
        private int id;
        private String nombres;
        private String apellidos;
        private String correo;
        private char dv;

        public Ejecutivo(String id, String run, String dv, String nombres, String apellidos, String correo)
        {
            this.id = int.Parse(id);
            this.run = run;
            this.dv = char.Parse(dv);
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.correo = correo;

        }



        private char Run { get; set; }
        private int Id_Usuario { get; set; }
        private String Nombres { get; set; }
        private String Apellidos { get; set; }
        private String Correo { get; set; }
        private char Dv { get; set; }

        public override List<String> ListaDatos()
        {
            return (new List<String> {  this.id.ToString(),
                                        this.run,
                                        this.dv.ToString(),
                                        this.nombres,
                                        this.apellidos,
                                        this.correo
                                        });

        }
    }
}
