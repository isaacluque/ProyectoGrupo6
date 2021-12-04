using Proyecto_Final.Modelos.DAO;
using Proyecto_Final.Modelos.Entidades;
using Proyecto_Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Controladores
{
    public class LoginController
    {
        LoginView Vista;
        UsuarioView vista2;

        public LoginController(LoginView view)
        {
            Vista = view;
            Vista.btn_IniciarSesion.Click += new EventHandler(ValidarUsuario);
        }

        public LoginController(UsuarioView view2)
        {
            vista2 = view2;
            vista2.btn_Registrar2.Click += new EventHandler(Registrar);
        }

        private void Registrar(object sender, EventArgs e)
        {
            if (vista2.txt_NombreU.Texts == "")
            {
                vista2.errorProvider1.SetError(vista2.txt_NombreU, "Ingrese su nombre");
                vista2.txt_NombreU.Focus();
                return;
            }
            if (vista2.txt_Correo2.Texts == "")
            {
                vista2.errorProvider1.SetError(vista2.txt_Correo2, "Ingrese su correo");
                vista2.txt_Correo2.Focus();
                return;
            }
            if (vista2.txt_Contraseña2.Texts == "")
            {
                vista2.errorProvider1.SetError(vista2.txt_Contraseña2, "Ingrese su contraseña");
                vista2.txt_Contraseña2.Focus();
                return;
            }

            UsuarioDAO usuarioDao = new UsuarioDAO();
            Usuario usuario = new Usuario();

            usuario.Nombre = vista2.txt_NombreU.Texts;
            usuario.Correo = vista2.txt_Correo2.Texts;
            usuario.Clave = vista2.txt_Contraseña2.Texts;

            bool insertar = usuarioDao.Registrar(usuario);

            if (insertar)
            {
                LoginView login = new LoginView();
                limpiar();
                MessageBox.Show("Se Registro Existosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                login.Show();
                vista2.Hide();
            }
            else MessageBox.Show("No se pudo registrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limpiar()
        {
            vista2.txt_NombreU.Clear();
            vista2.txt_Correo2.Clear();
            vista2.txt_Contraseña2.Clear();
        }

        public void ValidarUsuario(Object seder, EventArgs e)
        {
            UsuarioDAO userDAO = new UsuarioDAO();
            bool V = false;
            Usuario user = new Usuario();
            user.Correo = Vista.txt_Correo.Texts;
            user.Clave = Encriptacion(Vista.txt_Contraseña.Texts);

            V = userDAO.ValidarUsuario(user);
            if (V)
            {
                MenuView menu = new MenuView();
                Vista.Hide();
                System.Security.Principal.GenericIdentity identidad = new System.Security.Principal.GenericIdentity(Vista.txt_Correo.Texts);
                System.Security.Principal.GenericPrincipal principal = new System.Security.Principal.GenericPrincipal(identidad, null);
                System.Threading.Thread.CurrentPrincipal = principal;
                menu.Show();
            }
            else MessageBox.Show("Usuario Incorrecto");
        }

        public static string Encriptacion(string str)
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
