using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Modelos.DAO
{
    public class Conexion
    {
        protected SqlConnection LaConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ConnectionString);
    }
}
