using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaARD.Clases
{
    class Connection
    {
        public static string ObtenerConexion()
        {
            string CadenaConexion = "Data Source=.\\SQLEXPRESS; Initial Catalog=losnacimientos; Integrated Security=true;";

            return CadenaConexion;
        }

    }
}
