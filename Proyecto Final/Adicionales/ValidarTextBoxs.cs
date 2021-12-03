using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Adicionales
{
    class ValidarTextBoxs
    {
        public class SoloNumerosEnteros
        {
            public static void Comprobar(KeyPressEventArgs e)
            {
                if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                    return;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Valor no permitido, sólo debe ingresar números");
                }

            }

        }

        public class SoloLetras
        {
            public static void Comprobar(KeyPressEventArgs e)
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                    return;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Valor no permitido, sólo debe ingresar letras");
                }

            }

        }

        public class NoEscribir
        {
            public static void Comprobar(KeyPressEventArgs e)
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Valor no permitido, no se debe escribir en el Combobox");
                }
            }


        }
    }
}
