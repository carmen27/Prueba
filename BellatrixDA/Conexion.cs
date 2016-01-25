using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixDA
{
    public class Conexion
    {
        public static String strConexion = ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
    }
}
