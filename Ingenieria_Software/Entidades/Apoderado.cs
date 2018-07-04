using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software.Entidades
{
    public class Apoderado : EntidadesBD
    {
        private String apo_run;
        private int id_usuario;
        private String nombres;
        private String apellidos;
        private char dv;
        private String correo;

       public  Apoderado(String id_usuario, String run, String dv, String nombres, String apellidos, String correo)
        {
            this.apo_run = run;
            this.id_usuario = int.Parse(id_usuario);
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.dv = char.Parse(dv);
            this.correo = correo;
        }

        public override List<String>ListaDatos()
        {
            return (new List<String> {  this.id_usuario.ToString(),
                                        this.apo_run,
                                        this.dv.ToString(),
                                        this.nombres,
                                        this.apellidos,
                                        this.correo});
                                        
        }

        private char Apo_Run { get; set; }
        private int Id_Usuario { get; set; }
        private String Nombres { get; set; }
        private String Apellidos { get; set; }
        private char Dv { get; set; }
        private String Correo { get; set; }
        

    }
}
