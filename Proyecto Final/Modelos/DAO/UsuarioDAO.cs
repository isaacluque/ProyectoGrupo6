using Proyecto_Final.Modelos.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Proyecto_Final.Modelos.DAO
{
    public class UsuarioDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        private Conexion conectar = new Conexion();

        public bool ValidarUsuario(Usuario user)
        {
            bool v = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM USUARIO WHERE Correo=@Correo AND Clave=@Clave");

                comando.Connection = conectar.AbrirConexion();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Correo", SqlDbType.NChar, 20).Value = user.Correo;
                comando.Parameters.Add("@Clave", SqlDbType.NChar, 100).Value = user.Clave;
                v = Convert.ToBoolean(comando.ExecuteScalar());
                conectar.CerrarConexion();
            }
            catch (Exception)
            {
            }
            return v;

        }

        public bool Registrar(Usuario user)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO USUARIO(Nombre,Correo,Clave) VALUES (@Nombre,@Correo,@Clave); ");

                comando.Connection = conectar.AbrirConexion();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombre", SqlDbType.NChar, 20).Value = user.Nombre;
                comando.Parameters.Add("@Correo", SqlDbType.NChar, 20).Value = user.Correo;
                comando.Parameters.Add("@Clave", SqlDbType.NChar, 100).Value = Encriptar(user.Clave);
                comando.ExecuteNonQuery();
                conectar.CerrarConexion();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Usuario GetUsuarioPorEmail(string correo)
        {
            Usuario user = new Usuario();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM USUARIO ");
                sql.Append(" WHERE Correo = @Correo; ");

                comando.Connection = conectar.AbrirConexion();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Correo", SqlDbType.NChar, 20).Value = correo;
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    user.IdUsuario = (int)dr["IdUsuario"];
                    user.Nombre = (string)dr["Nombre"];
                    user.Correo = (string)dr["Correo"];
                }

                conectar.CerrarConexion();

            }
            catch (Exception)
            {
                conectar.CerrarConexion();
            }
            return user;
        }

        public static string Encriptar(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

    }
}
