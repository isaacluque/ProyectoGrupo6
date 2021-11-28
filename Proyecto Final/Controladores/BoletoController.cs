using Proyecto_Final.Modelos.DAO;
using Proyecto_Final.Modelos.Entidades;
using Proyecto_Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Controladores
{
    public class BoletoController
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
            //vista.btn_Modificar.Click += new EventHandler(Modificar);
            //vista.btn_Eliminar.Click += new EventHandler(Eliminar);
            //vista.btn_Cancelar.Click += new EventHandler(Cancelar);
        }

        private void Load(object sender, EventArgs e)
        {
            user = usuarioDAO.GetUsuarioPorEmail(System.Threading.Thread.CurrentPrincipal.Identity.Name);
            vista.txt_nombreUsuario.Text = user.Nombre;
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
