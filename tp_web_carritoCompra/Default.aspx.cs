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
        public List<Articulos> itemList { get; set; }
        //public ShoppingCart currentCart { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {




            if (Session["ItemList"] == null)
            {
                ArticulosNegocio iManager = new ArticulosNegocio();
                itemList = iManager.listar();
               // itemList = urlValidation(itemList);
                Session["ItemList"] = itemList;
            }
            else
            {

                itemList = (List<Articulos>)Session["ItemList"];
            }


        }
    }
}