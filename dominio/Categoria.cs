using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Categoria
    {

        [DisplayName("Categoria")]
        public string nombre_categoria { get; set; }
        [DisplayName("Id")]
        public int codigo_categoria { get; set; }

        public override string ToString()
        {
            return nombre_categoria;
        }

     
    }
}
