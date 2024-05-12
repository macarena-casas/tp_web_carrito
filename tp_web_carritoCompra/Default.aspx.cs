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
        public List<Articulos> listaArticulo { get; set; }
        public Carrito carritoactual { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {




            if (Session["listaarticulo"] == null)
            {
                ArticulosNegocio iManager = new ArticulosNegocio();
                listaArticulo = iManager.listar();
               // listaArticulo = urlValidation(listaArticulo);
                Session["listaarticulo"] = listaArticulo;
            }
            else
            {

                listaArticulo= (List<Articulos>)Session["listaarticulo"];
            }


        }
    }
}