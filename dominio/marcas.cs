﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Marca
    {
     public string Nombre {  get; set; }
     public int     Codigo { get; set; }
    

        public override string ToString()
        {
            return Nombre;
        }
    }
}
