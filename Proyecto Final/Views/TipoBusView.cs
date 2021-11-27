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
    public partial class TipoBusView : Form
    {
        public TipoBusView()
        {
            InitializeComponent();
            TipoBusController controller = new TipoBusController(this);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //UpdateForm();
        }
    }
}
