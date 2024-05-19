using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;
namespace tp_web_carritoCompra
{
    public partial class FinalizarCompra : System.Web.UI.Page
    {
        protected global::System.Web.UI.WebControls.Repeater repetirarticulos;
        public Carrito carritoactual { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            carritoactual = (Carrito)Session["carro"];
        
        }
 

        protected void btnComprar_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            string codigoa = btn.CommandArgument;
            EliminararticuloCarrito();
        

        }
   

    private void EliminararticuloCarrito()
        {

            carritoactual = new Carrito();

            Session.Add("carro", carritoactual);

            carritoactual = (Carrito) Session["carro"];

            updateLabelCart();
            if (carritoactual.TotalProductos == 0)
            {
                Response.Redirect("~/Default.aspx");
            }
        }



        private void updateLabelCart()
        {
            var masterPage = this.Master;
            var lblHeader = masterPage.FindControl("Label1") as Label;
            if (lblHeader != null)
            {
                lblHeader.Text = carritoactual.TotalProductos.ToString();
            }
        }

      
    }
}