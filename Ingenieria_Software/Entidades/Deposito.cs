using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software.Entidades
{
    class Deposito
    {
        private int id_deposito;
        private String rut_apoderado;
        private int monto_deposito;
        private int id_contrato;
        private DateTime fecha;

        public Deposito(int id_deposito, String rut_apoderado, int monto_deposito, int id_contrato, DateTime fecha)
        {
            this.id_deposito = id_deposito;
            this.rut_apoderado = rut_apoderado;
            this.monto_deposito = monto_deposito;
            this.id_contrato = id_contrato;
            this.fecha = fecha;
        }
        public int Id_deposito { get; set; }
        public String Rut_apoderado { get; set; }
        public int Monto_deposito { get; set; }
        public int Id_contrato { get; set; }
        public DateTime Fecha { get; set; }
    }
}
