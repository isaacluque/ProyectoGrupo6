using Proyecto_Final.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Views
{
    public partial class UsuarioView : Form
    {
        public UsuarioView()
        {
            InitializeComponent();
            LoginController comand = new LoginController(this);
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

        private void btn_VerContra2_MouseUp(object sender, MouseEventArgs e)
        {
            txt_Contraseña2.PasswordChar = true;
        }

        private void btn_VerContra2_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Contraseña2.PasswordChar = false;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Form frm = new LoginView();
            frm.Show();
            this.Hide();
        }
    }
}
