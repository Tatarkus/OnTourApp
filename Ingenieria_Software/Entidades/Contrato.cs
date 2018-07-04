using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software.Entidades
{
    class Contrato
    {
        private Char apo_run;
        private Char eje_run;
        private int id_viaje;
        private int id_contrato;
        private int id_seguro;
        private int id_curso;
        private DateTime fecha_inicio;
        private DateTime fecha_viaje;
        public Contrato(Char apo_run, Char eje_run, int id_viaje, int id_contrato, int id_seguro
            , int id_curso, DateTime fecha_inicio, DateTime fecha_viaje)
        {
            this.apo_run = apo_run;
            this.eje_run = eje_run;
            this.id_viaje = id_viaje;
            this.id_contrato = id_contrato;
            this.id_seguro = id_seguro;
            this.id_curso = id_curso;
            this.fecha_inicio = fecha_inicio;
            this.fecha_viaje = fecha_viaje;
        }
        public Char Apo_run { get; set; }
        public Char Eje_run { get; set; }
        public int Id_viaje { get; set; }
        public int Id_contrato { get; set; }
        public int Id_seguro { get; set; }
        public int Id_curso { get; set; }
        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_viaje { get; set; }
    }
}