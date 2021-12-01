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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss");
            labelFecha.Text = DateTime.Now.ToLongDateString();
            labelSaludo.Text = "¡Bienvenido " + Environment.UserName + ", esperamos que te guste el programa!";
            this.labelHora.Parent = this;
            this.labelHora.BackColor = Color.Transparent;
            this.labelFecha.Parent = this;
            this.labelFecha.BackColor = Color.Transparent;
            this.labelSaludo.Parent = this;
            this.labelSaludo.BackColor = Color.Transparent;
            timer1.Enabled = true;
        }

        private void Inicio_Paint(object sender, PaintEventArgs e)
        {
            // Área cliente del formulario.
            //
            Rectangle r = this.ClientRectangle;

            // Punto intermedio del área cliente.
            //
            int c = r.Width / 2;

            // Establecemos la nueva posición del control Label.
            //
            labelHora.Location = new Point(c - labelHora.Width / 2, labelHora.Location.Y);
            labelFecha.Location = new Point(c - labelFecha.Width / 2, labelFecha.Location.Y);
            labelSaludo.Location = new Point(c - labelSaludo.Width / 2, labelSaludo.Location.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss");
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Inicio_Resize(object sender, EventArgs e)
        {
            // invalidamos el formulario
            Invalidate();
        }
    }
}
