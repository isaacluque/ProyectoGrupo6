using Proyecto_Final.Modelos.DAO;
using Proyecto_Final.Modelos.Entidades;
using Proyecto_Final.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Controladores
{
    public class BoletoController : Conexion
    {
        BoletoView vista;
        BoletoDAO boletoDAO = new BoletoDAO();
        DestinoDAO destinoDAO = new DestinoDAO();
        TipoBusDAO tipoBusDAO = new TipoBusDAO();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        Usuario user = new Usuario();
        ComboBoxDAO cargarCombo = new ComboBoxDAO();


        public BoletoController(BoletoView view)
        {
            vista = view;
            vista.btn_guardar.Click += new EventHandler(Guardar);
            //vista.btn_listarDestino.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.cb_Destino.SelectedIndexChanged += new EventHandler(Precio);
            vista.cb_TipoBus.SelectedIndexChanged += new EventHandler(Precio);
            vista.btn_calcular.Click += new EventHandler(Precio_Total);
            //vista.cb_Destino.SelectedIndexChanged += new EventHandler(Precio_Total);
            //vista.cb_TipoBus.SelectedIndexChanged += new EventHandler(Precio_Total);

            //vista.btn_Modificar.Click += new EventHandler(Modificar);
            //vista.btn_Eliminar.Click += new EventHandler(Eliminar);
            //vista.btn_Cancelar.Click += new EventHandler(Cancelar);
        }

        private void Precio(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM DESTINO WHERE Destino='" + vista.cb_Destino.Text + "'", LaConexion);
            LaConexion.Open();
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.Read() == true)
            {
                vista.txt_preciodestino.Text = dr["Precio"].ToString();
                vista.txt_iddestino.Text = dr["IdDestino"].ToString();
            }
            LaConexion.Close();

            SqlCommand comando2 = new SqlCommand("SELECT * FROM TIPOBUS WHERE Descripcion='" + vista.cb_TipoBus.Text + "'", LaConexion);
            LaConexion.Open();
            SqlDataReader dr2 = comando2.ExecuteReader();
            if (dr2.Read() == true)
            {
                vista.txt_preciotipobus.Text = dr2["Precio"].ToString();
                vista.txt_idtipobus.Text = dr2["IdTipoBus"].ToString();
            }
            LaConexion.Close();
        }

        private void Precio_Total(object sender, EventArgs e)
        {
            decimal precio_total = 0, precio_destino, precio_tipobus;
            precio_destino = Convert.ToDecimal(vista.txt_preciodestino.Text);
            precio_tipobus = Convert.ToDecimal(vista.txt_preciotipobus.Text);
            precio_total = precio_destino + precio_tipobus;

            vista.txt_PrecioTotal.Text = precio_total.ToString();
        }

        private void Load(object sender, EventArgs e)
        {
            user = usuarioDAO.GetUsuarioPorEmail(System.Threading.Thread.CurrentPrincipal.Identity.Name);
            vista.txt_nombreUsuario.Text = user.Nombre;
            vista.txt_idusuario.Text = Convert.ToString(user.IdUsuario);
            ListarCategorias();
            ListarTipos();


        }
        private void Guardar(object sender, EventArgs e)
        {

        }
        private void ListarCategorias()
        {
            vista.cb_Destino.DataSource = cargarCombo.ListarCategorias();
            vista.cb_Destino.DisplayMember = "Destino";
            vista.cb_Destino.ValueMember = "IdDestino";

        }
        private void ListarTipos()
        {
            vista.cb_TipoBus.DataSource = cargarCombo.ListarTipos();
            vista.cb_TipoBus.DisplayMember = "Descripcion";
            vista.cb_TipoBus.ValueMember = "IdTipoBus";
        }

    }
}
