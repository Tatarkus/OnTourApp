using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
using System.Threading.Tasks;

namespace Ingenieria_Software
{
    class Conexion
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE=ONTOURDB; PASSWORD=ONTOURDB; USER ID=ONTOURDB;");

        ora.Open();

    }
   

}
