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
            Vista.btn_Inicio.Click += new EventHandler(ValidarUsuario);
        }

        public LoginController(UsuarioView view2)
        {
            vista2 = view2;
            vista2.btn_Registrarse.Click += new EventHandler(Registrar);
        }

        private void Registrar(object sender, EventArgs e)
        {
            if (vista2.txt_nombre.Text == "")
            {
                vista2.errorProvider1.SetError(vista2.txt_nombre, "Ingrese su nombre");
                vista2.txt_nombre.Focus();
                return;
            }
            if (vista2.txt_correo.Text == "")
            {
                vista2.errorProvider1.SetError(vista2.txt_correo, "Ingrese su correo");
                vista2.txt_correo.Focus();
                return;
            }
            if (vista2.txt_clave.Text == "")
            {
                vista2.errorProvider1.SetError(vista2.txt_clave, "Ingrese su contraseña");
                vista2.txt_clave.Focus();
                return;
            }

            UsuarioDAO usuarioDao = new UsuarioDAO();
            Usuario usuario = new Usuario();

            usuario.Nombre = vista2.txt_nombre.Text;
            usuario.Correo = vista2.txt_correo.Text;
            usuario.Clave = vista2.txt_clave.Text;

            bool insertar = usuarioDao.Registrar(usuario);

            if (insertar)
            {
                limpiar();
                MessageBox.Show("Se Registro Existosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo registrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiar()
        {
            vista2.txt_nombre.Clear();
            vista2.txt_correo.Clear();
            vista2.txt_clave.Clear();
        }

        public void ValidarUsuario(Object seder, EventArgs e)
        {
            UsuarioDAO userDAO = new UsuarioDAO();
            bool V = false;
            Usuario user = new Usuario();
            user.Correo = Vista.txt_Usuario.Text;
            user.Clave = Encriptacion(Vista.txt_Clave.Text);

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
