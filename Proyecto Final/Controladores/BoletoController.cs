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
using static Proyecto_Final.Adicionales.ValidarTextBoxs;

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
            //vista.btn_guardar.Click += new EventHandler(Guardar);
            vista.btn_GuardarBol.Click += new EventHandler(Guardar);
            //vista.btn_nuevoBoleto.Click += new EventHandler(Nuevo);
            vista.btn_NuevoBol.Click += new EventHandler(Nuevo);
            vista.Load += new EventHandler(Load);
            vista.cb_Destino.SelectedIndexChanged += new EventHandler(Precio);
            vista.cb_TipoBus.SelectedIndexChanged += new EventHandler(Precio);
            //vista.btn_calcular.Click += new EventHandler(Precio_Total);
            vista.btn_CalcularPT.Click += new EventHandler(Precio_Total);
            //vista.btn_Cancelar.Click += new EventHandler(Cancelar);
            vista.btn_CancelarOp.Click += new EventHandler(Cancelar);
            vista.cb_Destino.KeyPress += new KeyPressEventHandler(ValidarCombo);
            vista.cb_TipoBus.KeyPress += new KeyPressEventHandler(ValidarCombo);
        }

        private void Nuevo(object sender, EventArgs e)
        {
            Habilitar();
            LimpiarControles();
            ReiniciarPlaceHolders();
        }

        private void Cancelar(object sender, EventArgs e)
        {
            ReiniciarPlaceHolders();
            LimpiarControles();
            Desabilitar();
            //vista.errorProvider1.SetError(vista.txt_asiento, null);
            vista.errorProvider1.SetError(vista.txt_NumAsiento, null);
            //vista.errorProvider1.SetError(vista.txt_PrecioTotal, null);
            vista.errorProvider1.SetError(vista.txt_PrecioT, null);
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
                //vista.txt_preciodestino.Text = dr["Precio"].ToString();
                vista.txt_PrecioDest.Text = dr["Precio"].ToString();
                vista.txt_PrecioDest.Texts = dr["Precio"].ToString();
                //vista.txt_iddestino.Text = dr["IdDestino"].ToString();
                vista.txt_IdDest.Text = dr["IdDestino"].ToString();
                vista.txt_IdDest.Texts = dr["IdDestino"].ToString();
            }
            LaConexion.Close();

            SqlCommand comando2 = new SqlCommand("SELECT * FROM TIPOBUS WHERE Descripcion='" + vista.cb_TipoBus.Text + "'", LaConexion);
            LaConexion.Open();
            SqlDataReader dr2 = comando2.ExecuteReader();
            if (dr2.Read() == true)
            {
                //vista.txt_preciotipobus.Text = dr2["Precio"].ToString();
                vista.txt_PrecioBus.Text = dr2["Precio"].ToString();
                vista.txt_PrecioBus.Texts = dr2["Precio"].ToString();
                //vista.txt_idtipobus.Text = dr2["IdTipoBus"].ToString();
                vista.txt_IdTipoB.Text = dr2["IdTipoBus"].ToString();
                vista.txt_IdTipoB.Texts = dr2["IdTipoBus"].ToString();
            }
            LaConexion.Close();
        }

        private void Precio_Total(object sender, EventArgs e)
        {
            decimal precio_total, precio_destino, precio_tipobus;
            precio_destino = Convert.ToDecimal(vista.txt_PrecioDest.Text);
            //precio_destino = (Convert.ToDecimal(vista.txt_PrecioDest.Texts));
            precio_tipobus = Convert.ToDecimal(vista.txt_PrecioBus.Text);
            //precio_tipobus = (Convert.ToDecimal(vista.txt_PrecioBus.Texts));
            precio_total = precio_destino + precio_tipobus;

            //vista.txt_PrecioTotal.Text = precio_total.ToString();
            vista.txt_PrecioT.Text = precio_total.ToString();
            vista.txt_PrecioT.Texts = precio_total.ToString();
        }

        private void Load(object sender, EventArgs e)
        {
            ListarCategorias();
            ListarTipos();
            ListarBoleto();
            ReiniciarPlaceHolders();
            user = usuarioDAO.GetUsuarioPorEmail(System.Threading.Thread.CurrentPrincipal.Identity.Name);
            //vista.txt_nombreUsuario.Text = user.Nombre;
            vista.txt_NombreUs.Texts = user.Nombre;
            //vista.txt_idusuario.Text = Convert.ToString(user.IdUsuario);
            vista.txt_IdUs.Text = Convert.ToString(user.IdUsuario);
            vista.txt_IdUs.Texts = Convert.ToString(user.IdUsuario);
            vista.txt_IdUs.Enabled = false;
            vista.txt_IdTipoB.Enabled = false;
            vista.txt_IdDest.Enabled = false;
            vista.txt_NombreUs.Enabled = false;
            vista.txt_PrecioBus.Enabled = false;
            vista.txt_PrecioDest.Enabled = false;
            vista.txt_PrecioT.Enabled = false;
            Desabilitar();
        }
        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txt_PrecioT.Text == "")
            {
                //vista.errorProvider1.SetError(vista.txt_PrecioTotal, "Calcular el precio total");
                vista.errorProvider1.SetError(vista.txt_PrecioT, "Calcular el precio total");
                //vista.txt_PrecioTotal.Focus();
                vista.txt_PrecioT.Focus();
                return;
            }
            else vista.errorProvider1.SetError(vista.txt_PrecioT, null);            
            if (vista.txt_NumAsiento.Texts == "")
            {
                //vista.errorProvider1.SetError(vista.txt_asiento, "Ingrese un asiento");
                vista.errorProvider1.SetError(vista.txt_NumAsiento, "Ingrese un asiento");
                //vista.txt_asiento.Focus();
                vista.txt_NumAsiento.Focus();
                return;
            }
            else vista.errorProvider1.SetError(vista.txt_NumAsiento, null);            

            BoletoDAO boletoDAO = new BoletoDAO();
            Boleto boleto = new Boleto();

            //boleto.IdUsuario = Convert.ToInt32(vista.txt_idusuario.Text);
            boleto.IdUsuario = Convert.ToInt32(vista.txt_IdUs.Text);
            //boleto.IdTipoBus = Convert.ToInt32(vista.txt_idtipobus.Text);
            boleto.IdTipoBus = Convert.ToInt32(vista.txt_IdTipoB.Text);
            //boleto.IdDestino = Convert.ToInt32(vista.txt_iddestino.Text);
            boleto.IdDestino = Convert.ToInt32(vista.txt_IdDest.Text);
            //boleto.Asiento = Convert.ToInt32(vista.txt_asiento.Text);
            boleto.Asiento = Convert.ToInt32(vista.txt_NumAsiento.Texts);
            //boleto.Precio = Convert.ToDecimal(vista.txt_PrecioTotal.Text);
            boleto.Precio = Convert.ToDecimal(vista.txt_PrecioT.Text);
           
                bool inserto = boletoDAO.InsertarNuevoBoleto(boleto);
                if (inserto)
                {
                    ReiniciarPlaceHolders();
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
            //vista.txt_asiento.Clear();
            vista.txt_NumAsiento.Clear();
            //vista.txt_PrecioTotal.Clear();
            vista.txt_PrecioT.Clear();
            vista.txt_IdTipoB.Clear(); ;
            vista.txt_IdDest.Clear(); 
            //vista.txt_NombreUs.Clear(); 
            vista.txt_PrecioBus.Clear(); ;
            vista.txt_PrecioDest.Clear(); 
            vista.txt_PrecioT.Clear(); ;
        }

        private void ListarTipos()
        {
            vista.cb_TipoBus.DataSource = cargarCombo.ListarTipos();
            vista.cb_TipoBus.DisplayMember = "Descripcion";
            vista.cb_TipoBus.ValueMember = "IdTipoBus";
        }

        private void Desabilitar()
        {
            //vista.btn_guardar.Enabled = false;
            vista.btn_GuardarBol.Enabled = false;
            //vista.btn_calcular.Enabled = false;
            vista.btn_CalcularPT.Enabled = false;
            //vista.txt_asiento.Enabled = false;
            vista.txt_NumAsiento.Enabled = false;
            //vista.btn_Cancelar.Enabled = false;
            vista.btn_CancelarOp.Enabled = false;
            vista.cb_Destino.Enabled = false;
            vista.cb_TipoBus.Enabled = false;
        }

        private void Habilitar()
        {
            //vista.btn_guardar.Enabled = true;
            vista.btn_GuardarBol.Enabled = true;
            //vista.btn_calcular.Enabled = true;
            vista.btn_CalcularPT.Enabled = true;
            //vista.txt_asiento.Enabled = true;
            vista.txt_NumAsiento.Enabled = true;
            //vista.btn_Cancelar.Enabled = true;
            vista.btn_CancelarOp.Enabled = true;
            vista.cb_Destino.Enabled = true;
            vista.cb_TipoBus.Enabled = true;
        }

        private void ReiniciarPlaceHolders()
        {
            vista.txt_IdTipoB.PlaceholderText = "Id";
            vista.txt_IdDest.PlaceholderText = "Id";
            vista.txt_PrecioBus.PlaceholderText = "Precio de Bus";
            vista.txt_PrecioDest.PlaceholderText = "Precio del Destino";
            vista.txt_PrecioT.PlaceholderText = "Precio Total";
            vista.txt_NumAsiento.PlaceholderText = "Ingrese el Número de Asiento";
            vista.cb_TipoBus.Text = "Seleccione el Tipo de Bus";
            vista.cb_Destino.Text = "Seleccione su Destino";
        }

        private void ValidarCombo(object sender, KeyPressEventArgs e)
        {
            NoEscribir.Comprobar(e);
        }

    }
}
