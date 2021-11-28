﻿using System;
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
        public MenuView()
        {
            InitializeComponent();
        }

        private void Vista_FormClosedTipo(object sender, FormClosedEventArgs e)
        {
            vistaTipoBus = null;
        }

        private void tlbtn_TipoBus_Click(object sender, EventArgs e)
        {
            if(vistaTipoBus == null)
            {
                vistaTipoBus = new TipoBusView();
                vistaTipoBus.MdiParent = this;
                vistaTipoBus.FormClosed += Vista_FormClosedTipo;
                vistaTipoBus.Show();
            }
            else
            {
                vistaTipoBus.Activate();
            }


        }

        private void tsbtn_Destinos_Click(object sender, EventArgs e)
        {
            if (vistaDestino == null)
            {
                vistaDestino = new DestinoView();
                vistaDestino.MdiParent = this;
                vistaDestino.FormClosed += Vista_FormClosed2;
                vistaDestino.Show();
            }
            else
            {
                vistaDestino.Activate();
            }
        }

        private void Vista_FormClosed2(object sender, FormClosedEventArgs e)
        {
            vistaDestino = null;
        }

        private void tlbtn_Boleto_Click(object sender, EventArgs e)
        {
            if (vistaBoleto == null)
            {
                vistaBoleto = new BoletoView();
                vistaBoleto.MdiParent = this;
                vistaBoleto.FormClosed += Vista_FormClosed3;
                vistaBoleto.Show();
            }
            else
            {
                vistaBoleto.Activate();
            }
        }

        private void Vista_FormClosed3(object sender, FormClosedEventArgs e)
        {
            vistaBoleto = null;
        }
    }
}
