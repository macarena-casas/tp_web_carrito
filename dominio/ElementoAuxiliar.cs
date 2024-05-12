using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class ElementoAuxiliar
    {
        public Articulos articulo { get; set; }

        public int cantidad { get; set; }

        public decimal Subtotal { get; set; }

        public ElementoAuxiliar()
        {
            cantidad = 0;
            Subtotal = 0;

        }

    }
}
