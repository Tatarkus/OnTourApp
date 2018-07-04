using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Drawing;


#pragma warning disable CS0618 
// Usando Data.Oracle.Cliente en lugar de Oracle.DataAccess ç
//para evitar problemas de compatibilidad de arquitectura x86-x64

namespace DAOOntour
{
    public static class DAO
    {
        
    
        //STRING DE CONEXION A LA BASE DE DATOS
        private static String ConnectionString = "Data Source=DESKTOP-M4GKKSC;User ID=ontour;Password=asdf;";


        //OBJETO QUE REPRESENTA LA CONEXION A LA BASE DE DATOS

        private static OracleConnection con = new OracleConnection(ConnectionString);


        //OBJETO QUE REPRESENTA UN COMANDO PARA REALIZAR CONTRA LA BASE DE DATOS


        /*//GETS AND SETS
        public static SqlConnection Con { get => con; set => con = value; }
        public static SqlCommand Comando { get => comando; set => comando = value; }*/

        //Insertar un cliente recibe una lista de los atributos necesarios
        //para ingresar un cliente.
        //La lista de atributos debe estar ordenada de la siguiente forma
        //RUT,Nombres,Apellidos,FechaNacimiento,Sexo (string), EstadoCivil (string)


        public static Dictionary<string, string> Login(String user, String Password)
        {
            Dictionary<string, string> datos_login = new Dictionary<string, string>();
            try
            {
                OracleCommand cmd = new OracleCommand();
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();

                cmd.Connection = con;
                cmd.CommandText = ("SELECT ID_TIPO,RUN FROM USER WHERE username=" + user + " AND " + Password);

                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();

                    switch (dr.GetDecimal(0))
                    {
                        //EJECUTIVO
                        case 0:
                            datos_login = new Dictionary<string, string>(Obtener_ejecutivo(dr.GetString(1)));
                            break;
                        //APODERADO
                        case 1:
                            datos_login = new Dictionary<string, string>(Obtener_apoderados(dr.GetString(1)));
                            break;
                        //ALUMNO
                        case 2:
                            datos_login = new Dictionary<string, string>(Obtener_alumno(dr.GetString(1)));

                            break;
                    }

                    datos_login["tipo_usuario"] = (dr.GetDecimal(0).ToString());
                    return datos_login;
                }
                else
                {
                return null;
                }
            }
            catch (OracleException oe)
            {
                System.Diagnostics.Debug.WriteLine("ERROR NO SE PUDO CONECTAR A LA BASE DATOS");
                con.Close();
            }
            return null;

        }

        public static Bitmap Obtener_foto(String rut)
        {
            //SE ABRE LA CONEXION Y SE CARGA EL COMANDO SELECT * FROM POSTULANTE WHERE RUN = rut
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = ("SELECT * FROM POSTULANTE WHERE RUN=" + rut);


            try
            {
                //SE EJECUTA LA QUERY
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                //LA COLUMNA 7 TIENE EL CAMPO FOTO (parte en 0)
                //ACA DEBERIA CARGARSE EL BLOB PERO NO SE CARGA NADA
                //OracleBlob blob = dr.GetOracleBlobForUpdate(7);


                try
                {

                    //MemoryStream ms = new MemoryStream(blob.Value);
                    // Bitmap image = new Bitmap(ms);
                    con.Close();
                    return null;
                }
                catch (ArgumentException)
                {
                    System.Diagnostics.Debug.WriteLine("ERROR NO SE ENCONTRO LA IMAGEN DE: " + rut);
                    con.Close();
                }
            }

            catch (OracleException e)
            {
                //System.Diagnostics.Debug.WriteLine("ERROR: " + e.Number.ToString() + e.Message);
            }
            catch (InvalidOperationException e)
            {

            }
            finally
            {
                con.Close();
            }
            con.Close();
            return null;
        }



        public static Dictionary<string, string> Obtener_apoderados(String rut)
        {
            List<String> DatosPostulante = new List<String>();
            Dictionary<string, string> datos_pos = new Dictionary<string, string>();
            OracleCommand cmd = new OracleCommand("SELECT * FROM APODERADO WHERE APO_RUN=" + rut);
            //con.Open();
            try
            {
                cmd.Connection = con;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // output 
                    datos_pos.Add("run", dr.GetString(0));
                    datos_pos.Add("id", dr.GetDecimal(1).ToString());
                    datos_pos.Add("nombres", dr.GetString(2));
                    datos_pos.Add("apellidos", dr.GetString(3));
                    datos_pos.Add("dv", dr.GetString(4));
                    datos_pos.Add("correo", dr.GetString(5));
                }

            }
            catch (OracleException e)
            {

            }
            finally
            {
                //con.Close();

            }
            //con.Close();
            return datos_pos;

        }

        public static Dictionary<string, string> Obtener_alumno(String rut)
        {
            List<String> DatosPostulante = new List<String>();
            Dictionary<string, string> datos_alu = new Dictionary<string, string>();
            OracleCommand cmd = new OracleCommand("SELECT * FROM ALUMNO WHERE RUN=" + rut);
            //con.Open();
            try
            {
                cmd.Connection = con;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // output 
                    datos_alu.Add("run", dr.GetString(0));
                    datos_alu.Add("apo_run", dr.GetString(1));
                    datos_alu.Add("id_curso", dr.GetDecimal(2).ToString());
                    datos_alu.Add("id", dr.GetDecimal(3).ToString());
                    datos_alu.Add("dv", dr.GetString(4));
                    datos_alu.Add("nombres", dr.GetString(5));
                    datos_alu.Add("apellidos", dr.GetString(6));
                    
                    datos_alu.Add("correo", dr.GetString(7));
                }

            }
            catch (OracleException e)
            {

            }
            finally
            {
                //con.Close();

            }
            //con.Close();
            return datos_alu;

        }

        public static Dictionary<string, string> Obtener_ejecutivo(String rut)
        {
            List<String> DatosPostulante = new List<String>();
            Dictionary<string, string> datos_eje = new Dictionary<string, string>();
            OracleCommand cmd = new OracleCommand("SELECT * FROM APODERADO WHERE RUN=" + rut);
            //con.Open();
            try
            {
                cmd.Connection = con;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // output 
                    datos_eje.Add("run", dr.GetString(0));
                    datos_eje.Add("id", dr.GetDecimal(1).ToString());
                    datos_eje.Add("dv", dr.GetString(2));
                    datos_eje.Add("nombres", dr.GetString(3));
                    datos_eje.Add("apellidos", dr.GetString(4));
                    datos_eje.Add("correo", dr.GetString(5));
                }

            }
            catch (OracleException e)
            {

            }
            finally
            {
                //con.Close();

            }
            //con.Close();
            return datos_eje;

        }


        public static  List <Dictionary<string, string>> Obtener_apoderados()
        {
            //List<String> DatosPostulante = new List<String>();
            List<Dictionary<string, string>> lista_datos_apo = new List<Dictionary<string, string>>();
            Dictionary<string, string> datos_apo = new Dictionary<string, string> ();

            OracleCommand cmd = new OracleCommand("SELECT * FROM APODERADO");
            
            if(con.State == System.Data.ConnectionState.Closed)
                con.Open();
            try
            {
                cmd.Connection = con;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    datos_apo.Add("run", dr.GetString(0));
                    datos_apo.Add("id", dr.GetDecimal(1).ToString());
                    datos_apo.Add("nombres", dr.GetString(3));
                    datos_apo.Add("apellidos", dr.GetString(4));
                    datos_apo.Add("dv", dr.GetString(2));
                    datos_apo.Add("correo", dr.GetString(5));
                    lista_datos_apo.Add(new Dictionary<string, string>(datos_apo));
                    datos_apo.Clear();
                }

                foreach (Dictionary<string, string> apoderado in lista_datos_apo)
                {
                    System.Diagnostics.Debug.WriteLine(apoderado["apellidos"]);

                }
            }
            catch (OracleException e)
            {

            }
            finally
            {
               // con.Close();

            }
            //con.Close();
            return lista_datos_apo;

        }

        public static List<Dictionary<string, string>> Obtener_noticias()
        {
            //List<String> DatosPostulante = new List<String>();
            List<Dictionary<string, string>> lista_noticias = new List<Dictionary<string, string>>();
            Dictionary<string, string> noticia = new Dictionary<string, string>();
            

            OracleCommand cmd = new OracleCommand("SELECT * FROM NOTICIA");
            OracleLob info_noticias;

            //con.Open();
            try
            {
                cmd.Connection = con;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                noticia.Add("id", dr.GetDecimal(0).ToString());
                noticia.Add("id_tipo", dr.GetDecimal(1).ToString());
                noticia.Add("informacion", dr.GetString(2));
                    noticia.Add("fecha", dr.GetDateTime(4).Date.ToString());     
                lista_noticias.Add(new Dictionary<string, string>(noticia));
                noticia.Clear();
               } 

                foreach (Dictionary<string, string> apoderado in lista_noticias)
                {
                    System.Diagnostics.Debug.WriteLine(apoderado["id"]);

                }
            }
            catch (OracleException e)
            {

            }
            finally
            {
                // con.Close();

            }
            //con.Close();
            return lista_noticias;

        }

        /*public static String Obtener_cuerpo_noticia(int id)
        {
            String cuerpo;
            OracleCommand cmd = new OracleCommand("SELECT INFORMACION FROM NOTICIA WHERE ID_NOTICIA="+id);
            cmd.Connection = con;
            cmd.s = 8192;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               
            }
            return null;
        }*/

        public static List<Dictionary<string, string>> Obtener_mensajes()
        {
            return null;
        }

        public static List<Dictionary<string, string>> Obtener_viaje()
        {
            return null;
        }

        /*public static List<Dictionary<string, string>> Obtener_viaje()
        {
            return null;
        }*/ 


    }
}

