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
    public partial class MenuView : Form
    {
        TipoBusView vistaTipoBus;
        DestinoView vistaDestino;
        BoletoView vistaBoleto;
        public Form formularioHijoActual;
        private Size formSize; //MantengMantienea el tamaño del formulario cuando se minimice y restaure.
                               //porque tiene en cuenta el tamaño de la barra de título y los bordes.
        public MenuView()
        {
            InitializeComponent();
            AbrirFormularioHijo(new Inicio());
        }

        private void AbrirFormularioHijo(Form childForm)
        {

            if (formularioHijoActual != null)
            {
                //Abrir sólo el formulario 
                formularioHijoActual.Hide();
            }
            formularioHijoActual = childForm;
            //Final
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(childForm);
            panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void Vista_FormClosedTipo(object sender, FormClosedEventArgs e)
        {
            vistaTipoBus = null;
        }

        private void tlbtn_TipoBus_Click(object sender, EventArgs e)
        {
            //if(vistaTipoBus == null)
            //{
            //    vistaTipoBus = new TipoBusView();
            //    vistaTipoBus.MdiParent = this;
            //    vistaTipoBus.FormClosed += Vista_FormClosedTipo;
            //    vistaTipoBus.Show();
            //}
            //else
            //{
            //    vistaTipoBus.Activate();
            //}
            AbrirFormularioHijo(new TipoBusView());

        }

        private void tsbtn_Destinos_Click(object sender, EventArgs e)
        {
            //if (vistaDestino == null)
            //{
            //    vistaDestino = new DestinoView();
            //    vistaDestino.MdiParent = this;
            //    vistaDestino.FormClosed += Vista_FormClosed2;
            //    vistaDestino.Show();
            //}
            //else
            //{
            //    vistaDestino.Activate();
            //}
            AbrirFormularioHijo(new DestinoView());
        }

        private void Vista_FormClosed2(object sender, FormClosedEventArgs e)
        {
            vistaDestino = null;
        }

        private void tlbtn_Boleto_Click(object sender, EventArgs e)
        {
            //if (vistaBoleto == null)
            //{
            //    vistaBoleto = new BoletoView();
            //    vistaBoleto.MdiParent = this;
            //    vistaBoleto.FormClosed += Vista_FormClosed3;
            //    vistaBoleto.Show();
            //}
            //else
            //{
            //    vistaBoleto.Activate();
            //}
            AbrirFormularioHijo(new BoletoView());
        }

        private void Vista_FormClosed3(object sender, FormClosedEventArgs e)
        {
            vistaBoleto = null;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que quiere cerrar la aplicación?", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripTabItem4_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Inicio());
        }
    }
}
