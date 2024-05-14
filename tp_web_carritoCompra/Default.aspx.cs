using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;
using System.Net;


namespace tp_web_carritoCompra
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Articulos> listaarticulo { get; set; }
        public Carrito carritoactual { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["listaarticulo"] == null)
            {
                ArticulosNegocio iManager = new ArticulosNegocio();
                listaarticulo = iManager.Listacompleta();
               listaarticulo = validarurl(listaarticulo);
                Session["listaarticulo"] = listaarticulo;
            }
            else
            {

                listaarticulo= (List<Articulos>)Session["listaarticulo"];
            }
            
            carritoactual = (Carrito)Session["carro"];
        }

        private void addItem()
        {
          
            try
            {
                CarritoNegocio cManager = new CarritoNegocio();
                listaarticulo= (List<Articulos>)Session["listaarticulo"];
                Articulos articulo;
                string codigo_a = Request.QueryString["Codigo"];
                articulo = cManager.encontrarArticulo(codigo_a, listaarticulo);
                Session["Cart"] = cManager.AguegarArticuloAlCarrito(articulo, carritoactual, 1);

            }
            catch (Exception ex)
            {
                Response.Redirect("~/Default.aspx");// deberia redireccionar a pagina de error
                throw ex;
            }

        }
        public List<Articulos> validarurl(List<Articulos> aux)
        {
            foreach (Articulos art in aux)
            {
                foreach (Imagen image in art.Imagenes)
                {


                    try
                    {
                        if (image.Nombre_imagen != "sinimagen")
                        {
                            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(image.Nombre_imagen);
                            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                            if (response.StatusCode != HttpStatusCode.OK)
                            {

                                image.Nombre_imagen = "fallacarga";
                            }
                        }
                    }
                    catch (WebException)
                    {

                        image.Nombre_imagen = "fallacarga";

                    }

                }

            }

            return aux;
        }

    }
}