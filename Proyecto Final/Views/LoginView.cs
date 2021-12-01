using Proyecto_Final.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyecto_Final.Views
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            //prueba
            LoginController controlador = new LoginController(this);

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            Form frm = new UsuarioView();
            frm.Show();
            this.Hide();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Form frm = new UsuarioView();
            frm.Show();
            this.Hide();
        }

        private void btn_SalirProg_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que quiere cerrar la aplicación?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_VerContra_MouseUp(object sender, MouseEventArgs e)
        {
            txt_Contraseña.PasswordChar = true;
        }

        private void btn_VerContra_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Contraseña.PasswordChar = false;
        }


    }
}
