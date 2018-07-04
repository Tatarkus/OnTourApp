using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software.Entidades

{
    public static class ControladorEntidades
    {
        public static List<EntidadesBD> apoderados = new List<EntidadesBD>();
        public static EntidadesBD usuario_conectado;
        

        public static void AlmacenarApoderados(List<Dictionary<string,string>> datos_apoderados)
        {
            foreach (Dictionary<string, string> apoderado in datos_apoderados)
            {
                apoderados.Add(new Apoderado(apoderado["id"], apoderado["run"], apoderado["dv"], apoderado["nombres"], apoderado["apellidos"], apoderado["correo"]));

            }
            
        }

        public static void SesionUsuario(Dictionary<string, string> datos_login)
        {
            switch (datos_login["tipo_usuario"])
            {
                //EJECUTIVO
                case "0":
                    AlmacenarApoderados(DAOOntour.DAO.Obtener_apoderados());
                  
                    usuario_conectado = new Ejecutivo(datos_login["id"], datos_login["run"], datos_login["dv"],
                                                        datos_login["nombres"], datos_login["apellidos"], datos_login["correo"]);
                    break;
                    //APODERADO
                case "1":
                    usuario_conectado = new Apoderado(datos_login["id"], datos_login["run"],datos_login["dv"],
                                                        datos_login["nombres"], datos_login["apellidos"],datos_login["correo"]);
                    break;
                    //ALUMNO
                case "2":
                    usuario_conectado = new Alumno(datos_login["id"], datos_login["run"], datos_login["dv"],
                                                        datos_login["nombres"], datos_login["apellidos"], datos_login["correo"],
                                                        datos_login["apo_run"], datos_login["cod_curso"]);
                    break;
            }

        }
        

    }
}
