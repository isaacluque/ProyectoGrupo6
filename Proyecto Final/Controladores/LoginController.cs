using Proyecto_Final.Modelos.DAO;
using Proyecto_Final.Modelos.Entidades;
using Proyecto_Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Controladores
{
    public class LoginController
    {
        LoginView Vista;

        public LoginController(LoginView view)
        {
            Vista = view;
            Vista.btn_Inicio.Click += new EventHandler(ValidarUsuario);
        }
        public void ValidarUsuario(Object seder, EventArgs e)
        {
            UsuarioDAO userDAO = new UsuarioDAO();
            bool V = false;
            Usuario user = new Usuario();
            user.Correo = Vista.txt_Usuario.Text;
            user.Clave = Vista.txt_Clave.Text;

            V = userDAO.ValidarUsuario(user);
            if (V)
            {
                MessageBox.Show("Usuario Correcto");
                MenuView menu = new MenuView();
                Vista.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }

        /*public static string Encriptacion(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }*/
    }
}
