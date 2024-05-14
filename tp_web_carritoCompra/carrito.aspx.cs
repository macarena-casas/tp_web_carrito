using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
namespace tp_web_carritoCompra
{
    public partial class carrito : System.Web.UI.Page
    {
        protected global::System.Web.UI.WebControls.Repeater repetirarticulos;
        public Carrito carritoactual { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            carritoactual = (Carrito)Session["carro"];
            if (carritoactual.TotalProductos == 0)
            {
                Response.Redirect("~/Default.aspx");
            }
            else if (carritoactual != null && carritoactual.TotalProductos > 0)
            {
                repetirarticulos.DataSource = carritoactual.listaarticulo;
                repetirarticulos.DataBind();
            }
        }

        protected void btnMenos_Click(object sender, EventArgs e)
        {

        }

        protected void btnmas_Click(object sender, EventArgs e)
        {

        }


        protected void btnEliminarCarrito_Click(object sender, EventArgs e)
        {

        }

        protected void FinalizarCompra_Click(object sender, EventArgs e)
        {

            Session["carro"] = carritoactual;


        }

    }
}