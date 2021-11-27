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

namespace Proyecto_Final.Views
{
    public partial class UsuarioView : Form
    {
        public UsuarioView()
        {
            InitializeComponent();
            LoginController comand = new LoginController(this);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form frm = new LoginView();
            frm.Show();
            this.Hide();
        }

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {

        }
    }
}
