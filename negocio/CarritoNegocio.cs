﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;


namespace Negocio
{
    class CarritoNegocio
    {
        public Articulos encontrarArticulo(string CodigoObjeto, List<Articulos> aux)
        {
            Articulos articulo = new Articulos();
            foreach (Articulos actual in aux)
            {
                if (actual.codigo_a == CodigoObjeto)
                {
                    articulo = actual;
                    break;
                }
            }
            return articulo;

        }


        public Carrito AguegarArticuloAlCarrito(Articulos articulo, Carrito car, int cantidad)
        {
            bool existe = false;

            for (int x = 0; x < car.listaarticulo.Count(); x++)
            {
                if (car.listaarticulo[x].articulo.Id_a == articulo.Id_a)
                {
                    car.listaarticulo[x].cantidad += cantidad;
                    car.listaarticulo[x].Subtotal = car.listaarticulo[x].articulo.precio_a * car.listaarticulo[x].cantidad;
                    existe = true;

                }
            }
            if (existe == false)
            {
                ElementoAuxiliar aux = new ElementoAuxiliar();
                aux.articulo = articulo;
                aux.cantidad += cantidad;
                aux.Subtotal = articulo.precio_a * aux.cantidad;
                car.listaarticulo.Add(aux);

            }
            car.TotalPrecio = car.listaarticulo.Sum(aux => aux.cantidad * aux.articulo.precio_a);
            car.TotalProductos = car.listaarticulo.Sum(aux => aux.cantidad);
            return car;
        }
    }
}
