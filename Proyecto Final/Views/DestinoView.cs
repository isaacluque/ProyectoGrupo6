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
    public partial class DestinoView : Form
    {
        public DestinoView()
        {
            InitializeComponent();
            DestinoController controlador = new DestinoController(this);
        }
    }
}
