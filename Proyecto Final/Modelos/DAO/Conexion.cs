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

        //static private string Conectar =  LaConexion

        //private SqlConnection Connection = new SqlConnection(LaConexion);
        //public SqlConnection AbrirConexion()
        //{
        //    if (Connection.State == ConnectionState.Closed)
        //        Connection.Open();
        //    return Connection;
        //}
        //public SqlConnection CerrarConexion()
        //{
        //    if (Connection.State == ConnectionState.Open)
        //        Connection.Close();
        //    return Connection;
        //}



    }
}
