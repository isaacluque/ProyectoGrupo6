using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Final.Modelos.DAO
{
    public class ComboBoxDAO : Conexion
    {
        private Conexion conectar = new Conexion();

        private SqlCommand comando = new SqlCommand();

        private SqlDataReader leer;

        public DataTable ListarCategorias()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conectar.AbrirConexion();
            comando.CommandText = "SP_CARGARCOMBOBOX";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            leer.Close();
            conectar.CerrarConexion();
            return Tabla;
        }

        public DataTable ListarTipos()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conectar.AbrirConexion();
            comando.CommandText = "SP_CARGARCOMBOBOXTIPO";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            leer.Close();
            conectar.CerrarConexion();
            return Tabla;
        }
    }
}
