using Proyecto_Final.Modelos.DAO;
using Proyecto_Final.Modelos.Entidades;
using Proyecto_Final.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        Boleto boleto = new Boleto();

        public BoletoController(BoletoView view)
        {
            vista = view;
            vista.btn_guardar.Click += new EventHandler(Guardar);
            vista.btn_nuevoBoleto.Click += new EventHandler(Nuevo);
            vista.Load += new EventHandler(Load);
            vista.cb_Destino.SelectedIndexChanged += new EventHandler(Precio);
            vista.cb_TipoBus.SelectedIndexChanged += new EventHandler(Precio);
            vista.btn_calcular.Click += new EventHandler(Precio_Total);
            

            vista.btn_Cancelar.Click += new EventHandler(Cancelar);
        }

        private void Nuevo(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void Cancelar(object sender, EventArgs e)
        {

            LimpiarControles();
            Desabilitar();
            vista.errorProvider1.SetError(vista.txt_asiento, null);
            vista.errorProvider1.SetError(vista.txt_PrecioTotal, null);
            boleto = null;
        }

        private void ListarBoleto()
        {
            vista.dataGridView_boleto.DataSource = boletoDAO.GetBoleto();
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
            ListarBoleto();

        }
        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txt_PrecioTotal.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_PrecioTotal, "Calcular el precio total");
                vista.txt_PrecioTotal.Focus();
                return;
            }
            else vista.errorProvider1.SetError(vista.txt_PrecioTotal, null);            
            if (vista.txt_asiento.Text == "")
            {
                
                vista.errorProvider1.SetError(vista.txt_asiento, "Ingrese un asiento");
                vista.txt_asiento.Focus();
                return;
            }
            else vista.errorProvider1.SetError(vista.txt_asiento, null);            

            BoletoDAO boletoDAO = new BoletoDAO();
            Boleto boleto = new Boleto();

            boleto.IdUsuario = Convert.ToInt32(vista.txt_idusuario.Text);
            boleto.IdTipoBus = Convert.ToInt32(vista.txt_idtipobus.Text);
            boleto.IdDestino = Convert.ToInt32(vista.txt_iddestino.Text);
            boleto.Asiento = Convert.ToInt32(vista.txt_asiento.Text);
            boleto.Precio = Convert.ToDecimal(vista.txt_PrecioTotal.Text);

           
                bool inserto = boletoDAO.InsertarNuevoBoleto(boleto);
                if (inserto)
                {
                    Desabilitar();
                    LimpiarControles();
                    ListarBoleto();
                    MessageBox.Show("Boleto creado exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo crear el boleto");
                }
            
        }
        private void ListarCategorias()
        {
            vista.cb_Destino.DataSource = cargarCombo.ListarCategorias();
            vista.cb_Destino.DisplayMember = "Destino";
            vista.cb_Destino.ValueMember = "IdDestino";

        }

        private void LimpiarControles()
        {
            vista.txt_asiento.Clear();
            vista.txt_PrecioTotal.Clear();
        }

        private void ListarTipos()
        {
            vista.cb_TipoBus.DataSource = cargarCombo.ListarTipos();
            vista.cb_TipoBus.DisplayMember = "Descripcion";
            vista.cb_TipoBus.ValueMember = "IdTipoBus";
        }

        private void Desabilitar()
        {
            vista.btn_guardar.Enabled = false;
            vista.btn_calcular.Enabled = false;
            vista.txt_asiento.Enabled = false;
            vista.btn_Cancelar.Enabled = false;
        }

        private void Habilitar()
        {
            vista.btn_guardar.Enabled = true;
            vista.btn_calcular.Enabled = true;
            vista.txt_asiento.Enabled = true;
            vista.btn_Cancelar.Enabled = true;
        }

    }
}
