using Proyecto_Final.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Modelos.DAO
{
    public class UsuarioDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool ValidarUsuario(Usuario user)
        {
            bool v = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM USUARIO WHERE Correo=@Correo AND Clave=@Clave");

                comando.Connection = LaConexion;
                LaConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Correo", SqlDbType.NChar, 20).Value = user.Correo;
                comando.Parameters.Add("@Clave", SqlDbType.NChar, 100).Value = user.Clave;
                v = Convert.ToBoolean(comando.ExecuteScalar());
            }
            catch (Exception)
            {

                throw;
            }
            return v;

        }

        public bool Registrar(Usuario user)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO USUARIO(Nombre,Correo,Clave) VALUES (@Nombre,@Correo,@Clave); ");

                comando.Connection = LaConexion;
                LaConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombre", SqlDbType.NChar, 20).Value = user.Nombre;
                comando.Parameters.Add("@Correo", SqlDbType.NChar, 20).Value = user.Correo;
                comando.Parameters.Add("@Clave", SqlDbType.NChar, 100).Value = Encriptar(user.Clave);

                comando.ExecuteNonQuery();
                LaConexion.Close();
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

                comando.Connection = LaConexion;
                LaConexion.Open();
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

                LaConexion.Close();

            }
            catch (Exception)
            {
                LaConexion.Close();

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
