
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
    public partial class MyMaster : System.Web.UI.MasterPage
    {
        public Carrito CarroCompra { get; set; }
        public List<Articulos> listafiltrada { get; set; }

        public string TotalProductosCarro { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack && Session["carro"] == null)
            {
                CarroCompra = new Carrito();
             
                Session.Add("carro", CarroCompra);
            }
            else
            {
                CarroCompra = (Carrito)Session["carro"];
                
            }
            Label1.Text = CarroCompra.TotalProductos.ToString();

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if(tbBuscar.Text != "")
            {
                Buscar(tbBuscar.Text);
            }
        }
        protected void Buscar (string text)
        {
            List<Articulos> aux = (List<Articulos>)Session["listaarticulo"];
            listafiltrada = aux.FindAll(x => x.nombre_a.ToUpper().Contains(text.ToUpper()) ||
            x.marca_a.Nombre.ToUpper().Contains(text.ToUpper()) ||
            x.categoria_a.nombre_categoria.ToUpper().Contains(text.ToUpper()));
            Session.Add("articulosfiltrados", listafiltrada);
            if(!string.Equals(Request.Url.AbsolutePath, "/Default.aspx", StringComparison.OrdinalIgnoreCase))
            {
                Response.Redirect($"Default.aspx");
            }



        }

    }
}