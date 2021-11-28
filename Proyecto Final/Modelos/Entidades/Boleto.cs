using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Modelos.Entidades
{
    public class Boleto
    {
        public int IdBoleto { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipoBus { get; set; }
        public int IdDestino { get; set; }
        public int Asiento { get; set; }
        public decimal Precio { get; set; }

    }
}
