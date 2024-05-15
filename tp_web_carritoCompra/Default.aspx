<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="tp_web_carritoCompra.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <% if ((List<dominio.Articulos>)Session["articulosfiltrados"] != null)
        {
            listaarticulo = (List<dominio.Articulos>)Session["articulosfiltrados"];
            Session.Remove("articulosfiltrados");
        }

    %>

    <div class="row" style="margin-top: 100px; margin-left: 25px; margin-right: 25px; margin-bottom: 40px;">

        <% foreach (dominio.Articulos articulo in listaarticulo)

            { %>
        <div class="col-12 col-md-6 col-lg-4 mb-2">

            <div class="card border-success" style="border-color: darkgray; height: 600px; width: 400px">
                <a href="<%: ResolveUrl("~/Detalles.aspx?id=" + articulo.Id_a) %>">

                    <% if (articulo.Imagenes[0].Nombre_imagen == "fallacarga")
                        { %>
                    <img src="https://previews.123rf.com/images/yoginta/yoginta2301/yoginta230100567/196853824-imagen-no-encontrada-ilustraci%C3%B3n-vectorial.jpg" class="card-img-top" style="object-fit: scale-down; height: 25vh; width: 100%;" alt="Image">
                    <% }
                        else if (articulo.Imagenes[0].Nombre_imagen == "sinimagen")
                        { %>
                    <img src="https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg" class="card-img-top" style="object-fit: scale-down; height: 25vh; width: 100%;" alt="Image">
                    <% }
                        else
                        { %>
                    <img src="<%:articulo.Imagenes[0].Nombre_imagen  %>" class="card-img-top" style="object-fit: scale-down; height: 25vh; width: 100%;" alt="Image">
                    <% }  %>
                </a>


                <center>
                    <div class="card-header text-center" style="font-size: 40px; color: darkgreen;"><strong><%: articulo.nombre_a  %></strong></div>
                    <div class="card-body text-center" style="margin-bottom: 20px;">
                        <h5 class="card-title" style="font-size: 30px; color: black;">$<%: articulo.precio_a  %></h5>
                        <p class="card-text" style="font-size: 30px; color: black;"><%:articulo.marca_a.Nombre%></p>
                        <p class="card-text" style="font-size: 30px; color: black;"><%:articulo.categoria_a.nombre_categoria%></p>
                        <a href="Default.aspx?Codigo=<%:articulo.codigo_a %>" class="btn btn-outline-light" usesubmitbehavior="false" commandargument='<%=articulo.codigo_a%>'
                            style="background-color: seagreen; color: white; font-weight: bold; border-color: dimgray">Agregar al Carro </a>
                        <a href="<%: ResolveUrl("~/Detalles.aspx?id=" + articulo.Id_a) %>" class="btn btn-outline-secondary" style="font-weight: bold; border-color: dimgrey;" title="Detalles">+</a>

                    </div>
                </center>
            </div>
        </div>

        <%

            } %>
    </div>

</asp:Content>
