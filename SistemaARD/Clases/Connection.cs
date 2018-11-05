using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaARD.Properties;
using System.Configuration;

namespace SistemaARD.Clases
{
    class Connection
    {
        public static string ObtenerString()
        {
            return Settings.Default.BD_LosNaci_Reportes;
        }

        public static string ObtenerConexion()
        {
            string CadenaConexion = ObtenerString();

            return CadenaConexion;
        }

    }
}
