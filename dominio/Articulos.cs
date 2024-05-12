﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulos
    {
        [DisplayName("Nombre")]
        public string nombre_a {get; set; }
        [DisplayName("Codigo")]
        public string codigo_a { get; set; }
        public int Id_a{ get; set; }
        [DisplayName("Precio")]
        public decimal precio_a { get; set; }
        [DisplayName("Descripción")]
        public string descripcion_a { get; set; }
        [DisplayName("Categoria")]
        public Categoria categoria_a { get; set; }
        [DisplayName("Marca")]
        public Marca marca_a { get; set; }
        [DisplayName("Imagen1")]
        public Imagen imagen_a{ get; set; }
        [DisplayName("Imagen")]
        public string urlimagen { get; set; }
        public int ID() { return Id_a; }
        public List<Imagen> Imagenes { get; set; }
        
        public Articulos()
        {
            precio_a = 0;
            nombre_a = "nada";
            descripcion_a = "nada";
            marca_a = new Marca();
            categoria_a = new Categoria();
            Imagenes = new List<Imagen>();
            
        }
        public Articulos(string cod,string nom, string desc,Marca mar,Categoria cat,decimal pre)
        {
            marca_a = new Marca();
            categoria_a = new Categoria();
            codigo_a = cod;
            nombre_a = nom;
            descripcion_a = desc;
            marca_a = mar;
            categoria_a = cat;
            precio_a = pre;
            Imagenes = new List<Imagen>();
        }
    }
}
