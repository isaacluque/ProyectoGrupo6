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
    public partial class BoletoView : Form
    {
        public BoletoView()
        {
            InitializeComponent();
            BoletoController controlador = new BoletoController(this);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
