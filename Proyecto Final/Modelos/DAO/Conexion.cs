using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Modelos.DAO
{
    public class Conexion
    {
        protected SqlConnection LaConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ConnectionString);
        public SqlConnection AbrirConexion()
        {
            if (LaConexion.State == ConnectionState.Closed)
                LaConexion.Open();
            return LaConexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (LaConexion.State == ConnectionState.Open)
                LaConexion.Close();
            return LaConexion;
        }
    }
}
