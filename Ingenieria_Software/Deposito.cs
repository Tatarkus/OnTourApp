using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;

namespace Ingenieria_Software
{
    public class Deposito
    {
        private int id_deposito;
        private String rut_apoderado;
        private int monto_deposito;
        private int id_contrato;
        private DateTime fecha;

        public Deposito(int id_deposito, String rut_apoderado,int monto_deposito, int id_contrato, DateTime fecha) 
        {
            this.id_deposito = id_deposito;
            this.rut_apoderado = rut_apoderado;
            this.monto_deposito = monto_deposito;
            this.id_contrato = id_contrato;
            this.fecha = fecha;
        }
        //set
        public void setRut(String rut_apoderado)
        {
            this.rut_apoderado = rut_apoderado;

        }
        public void setDeposito(int id_deposito)
        {
            this.id_deposito = id_deposito;

        }
        public void setMonto(int monto_deposito)
        {
            this.monto_deposito = monto_deposito;

        }
        public void setContrato(int id_contrato)
        {
            this.id_contrato = id_contrato;

        }
        public void setFecha(DateTime fecha)
        {
            this.fecha = fecha;

        }

        public int getDeposito()
        {
            return id_deposito;
        }
        public String getApoderado()
        {
            return rut_apoderado;
        }
        public int getMonto()
        {
            return monto_deposito;
        }
        public int getContrato()
        {
            return id_contrato;
        }
        public DateTime getFecha()
        {
            return fecha;
        }
        /*
        public void setComprobante(Deposito dep)
        {
            List<String> DatosPostulante = new List<String>();
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
            OracleConnection con = new OracleConnection("DATA SOURCE =desktop-uln6p59;PASSWORD = ontourdb ;USER ID =ontourdb");
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            //select 
            cmd.CommandText = ("SELECT NOMBRES,APELLIDOS FROM APODERADO WHERE APO_RUN=" + dep.rut_apoderado);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            DatosPostulante.Add(dr.GetString(0));
            DatosPostulante.Add(dr.GetString(1));

            //insert
            String SQL = "insert into comprobante values(s_comprobante.nextval,:apo_run,:nom,:apellidos,:monto,:id_contrato,:fecha)";
            OracleCommand cmdi = new OracleCommand();
            cmdi.CommandType = CommandType.Text;
            cmdi.CommandText = SQL;
            cmdi.Parameters.Add("apo_run", OracleType.Char).Value = dep.rut_apoderado;
            cmdi.Parameters.Add("nom",OracleType.VarChar).Value= DatosPostulante[0];
            cmdi.Parameters.Add("apellidos", OracleType.VarChar).Value = DatosPostulante[1];
            cmdi.Parameters.Add("monto", OracleType.Number).Value = dep.monto_deposito;
            cmdi.Parameters.Add("id_contrato", OracleType.Number).Value = dep.id_contrato   ;
            cmdi.Parameters.Add("fecha", OracleType.Number).Value = dep.fecha;
            cmdi.ExecuteNonQuery();
        }
        */
    }
}
