using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software.Entidades
{
    class Alumno : EntidadesBD
    {
        private String run;
        private char dv;
        private int id;
        private String apo_run;
        private String nombres;
        private String apellidos;
        private String correo;
        private int cod_curso;


        public Alumno(String id, String run, String dv, String nombres, String apellidos , String correo ,String apo_run, String  cod_curso)
        {
            this.id = int.Parse(id); 
            this.run = run;
            this.dv = char.Parse(dv) ;
            this.nombres = nombres ; 
            this.apellidos = apellidos; 
            this.correo = correo ;
            this.apo_run = apo_run;
            this.cod_curso = int.Parse(cod_curso);
        }

        private char Run { get; set; }
        private int  DV { get; set; }
        private char Apo_Run { get; set; }
        private String Nombres { get; set; }
        private String Apellidos { get; set; }
        private String Correo { get; set; }

       
            public override List<String> ListaDatos()
            {
                return (new List<String> {  this.id.ToString(),
                                        this.run,
                                        this.dv.ToString(),
                                        this.nombres,
                                        this.apellidos,
                                        this.correo,
                                        this.apo_run,
                                        this.cod_curso.ToString()
                                        });

            }
        
    }
}
