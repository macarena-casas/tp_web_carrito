using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;
namespace tp_web_carritoCompra
{
    public partial class Detalles : System.Web.UI.Page
    {
        public List<Articulos> listaarticulo { get; set; }
        public Articulos articulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            listaarticulo = (List<Articulos>)Session["listaarticulo"];
            int Id_a = Request.QueryString["Id"] != null && int.TryParse(Request.QueryString["Id"], out int id) ? id : -1;
            articulo = listaarticulo.FirstOrDefault(i => i.Id_a == Id_a);
            try
            {

                if (articulo != null && !IsPostBack)
                {
                    lblnombre.InnerText = articulo.nombre_a;
                    lblDescripcion.InnerText = articulo.descripcion_a;
                    lblmarca.InnerText = articulo.marca_a.Nombre;
                    lblprecio.InnerText = "$" + articulo.precio_a.ToString();
                }

                if (articulo == null)
                {
                    Response.Redirect("~/Default.aspx");
                }

            }
            catch (Exception ex)
            {
                Response.Redirect("~/Default.aspx");
                throw ex;
            }
        }
        protected void btnDetalleagregaralcarro_Click(object sender, EventArgs e)
        {
            int selectedQuantity;
            Carrito carritoactual;
            carritoactual = (Carrito)Session["carro"];
            CarritoNegocio cNegocio = new CarritoNegocio();

            try
            {

                if (selectUnit.SelectedIndex > 0)
                {
                    selectedQuantity = int.Parse(selectUnit.Value);
                }
                else
                {
                    selectedQuantity = 1;
                }

                carritoactual = cNegocio.AguegarArticuloAlCarrito(articulo, carritoactual, selectedQuantity);
                Session["carro"] = carritoactual;
                Response.Redirect("~/Detalles.aspx?id=" + articulo.Id_a);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}