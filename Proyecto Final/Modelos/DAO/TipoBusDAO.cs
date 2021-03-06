using Proyecto_Final.Modelos.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Proyecto_Final.Modelos.DAO
{
    public class TipoBusDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
        private Conexion conectar = new Conexion();
        public bool InsertarNuevoTipoBus(TipoBus tipoBus)
        {
            bool inserto = false;
            try
            {
                LaConexion.Close();
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO TIPOBUS(Descripcion,Precio) VALUES (@Descripcion, @Precio);");


                comando.Connection = conectar.AbrirConexion();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 20).Value = tipoBus.Descripcion;
                comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = tipoBus.Precio;
                comando.ExecuteNonQuery();
                inserto = true;
                conectar.CerrarConexion();
            }
            catch (Exception )
            {
                inserto = false;
            }
            return inserto;
        }

        public DataTable GetTipoBus()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM TIPOBUS ");
                comando.Connection = conectar.AbrirConexion();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                conectar.CerrarConexion();
            }
            catch (Exception)
            {

            }
            return dt;
        }

        public bool EliminarTipo(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("DELETE FROM TIPOBUS WHERE IdTipoBus = @IdTipoBus;");
                comando.Connection = conectar.AbrirConexion();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IdTipoBus", SqlDbType.Int).Value = id;
                comando.ExecuteNonQuery();
                modifico = true;
                conectar.CerrarConexion();
            }
            catch (Exception)
            {
                return modifico;
            }
            return modifico;
        }

        public bool ActualizarTipoBus(TipoBus tipoBus)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE TIPOBUS ");
                sql.Append(" SET Descripcion = @Descripcion, Precio = @Precio ");
                sql.Append(" WHERE IdTipoBus = @IdTipoBus; ");

                comando.Connection = conectar.AbrirConexion();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IdTipoBus", SqlDbType.Int).Value = tipoBus.IdTipoBus;
                comando.Parameters.Add("@Descripcion", SqlDbType.NChar, 20).Value = tipoBus.Descripcion;
                comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = tipoBus.Precio;
                comando.ExecuteNonQuery();
                modifico = true;
                conectar.CerrarConexion();
            }
            catch (Exception )
            {
                return modifico;
            }
            return modifico;
        }
    }
}
