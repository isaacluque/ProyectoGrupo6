using Proyecto_Final.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Modelos.DAO
{
    public class DestinoDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
        private Conexion conectar = new Conexion();

        public bool InsertarNuevoDestino(Destino destino)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO DESTINO ");
                sql.Append(" VALUES (@Destino, @Precio); ");

                comando.Connection = conectar.AbrirConexion();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Destino", SqlDbType.NChar, 40).Value = destino.Destinos;
                comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = destino.PRECIO;
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

        public bool ActualizarDestino(Destino destino)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE DESTINO ");
                sql.Append(" SET Destino = @Destino, Precio = @Precio ");
                sql.Append(" WHERE IdDestino = @Id; ");

                comando.Connection = conectar.AbrirConexion();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = destino.ID;
                comando.Parameters.Add("@Destino", SqlDbType.NChar, 40).Value = destino.Destinos;
                comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = destino.PRECIO;
                comando.ExecuteNonQuery();
                modifico = true;
                conectar.CerrarConexion();
            }
            catch (Exception ex)
            {

                return modifico;
            }

            return modifico;

        }

        public bool EliminarDestino(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM DESTINO ");
                sql.Append(" WHERE IdDestino = @Id; ");

                comando.Connection = conectar.AbrirConexion();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
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

        public DataTable GetDestino()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM DESTINO ");

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
    }
}
