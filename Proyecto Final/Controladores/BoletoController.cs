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
        }

        private void Guardar(object sender, EventArgs e)
        {
            
        }
    }
}
