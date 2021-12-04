using Proyecto_Final.Modelos.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Proyecto_Final.Modelos.DAO
{
    public class BoletoDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        Conexion conectar = new Conexion();

        public bool InsertarNuevoBoleto(Boleto boleto)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO BOLETO ");
                sql.Append(" VALUES (@IdUsuario, @IdTipoBus, @IdDestino, @Asiento, @Precio); ");

                comando.Connection = conectar.AbrirConexion();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = boleto.IdUsuario;
                comando.Parameters.Add("@IdTipoBus", SqlDbType.Int).Value = boleto.IdTipoBus;
                comando.Parameters.Add("@IdDestino", SqlDbType.Int).Value = boleto.IdDestino;
                comando.Parameters.Add("@Asiento", SqlDbType.Int).Value = boleto.Asiento;
                comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = boleto.Precio;
                comando.ExecuteNonQuery();
                inserto = true;
                conectar.CerrarConexion();
            }
            catch (Exception)
            {
                inserto = false;
            }
            return inserto;
        }

        public DataTable GetBoleto()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM BOLETO ");

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

        public bool EliminarBoleto(int id)
        {
            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM BOLETO ");
                sql.Append(" WHERE IdBoleto = @Id; ");

                comando.Connection = conectar.AbrirConexion();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                comando.ExecuteNonQuery();
                elimino = true;
                conectar.CerrarConexion();
            }
            catch (Exception)
            {
                return elimino;
            }
            return elimino;
        }
    }
}
