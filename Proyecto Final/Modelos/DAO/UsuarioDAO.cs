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
                comando.Parameters.Add("@Correo", SqlDbType.NVarChar, 50).Value = user.Correo;
                comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 30).Value = user.Clave;
                v = Convert.ToBoolean(comando.ExecuteScalar());
            }
            catch (Exception)
            {

                throw;
            }
            return v;
        }
    }
}
