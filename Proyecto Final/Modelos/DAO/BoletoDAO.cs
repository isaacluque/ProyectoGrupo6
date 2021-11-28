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
    public class BoletoDAO : Conexion
    {
        DestinoDAO destinoDAO = new DestinoDAO();
        TipoBusDAO tipoBusDAO = new TipoBusDAO();
        UsuarioDAO usuarioDAO = new UsuarioDAO();

        SqlCommand comando = new SqlCommand();

        Conexion conexion = new Conexion();

        //public DataTable cargarcombo()
        //{
        //    SqlDataAdapter da = new SqlDataAdapter("SP_CARGARCOMBOBOX", conexion);
        //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);


        //    return dt;
        //}
    
    }



    

}
