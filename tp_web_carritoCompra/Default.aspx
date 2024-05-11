<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="tp_web_carritoCompra.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>holaa   </h1>

    <div class="row" style="margin-top: 100px; margin-left: 25px; margin-right: 25px; margin-bottom: 40px;">

        <% foreach (dominio.Articulos articulo in itemList)

            { %>
        <div class="col-12 col-md-6 col-lg-4 mb-2">

            <div class="card border-success" style="border-color: darkgray; height: 600px; width: 400px">

                <img src="https://img.freepik.com/foto-gratis/colores-arremolinados-interactuan-danza-fluida-sobre-lienzo-que-muestra-tonos-vibrantes-patrones-dinamicos-que-capturan-caos-belleza-arte-abstracto_157027-2892.jpg" class="card-img-top" style="object-fit: scale-down; height: 30vh; width: 100%;" alt="...">

                <center>
                    <div class="card-header text-center" style="font-size: 40px; color: darkgreen;"><%: articulo.nombre_a  %></div>
                    <div class="card-body text-center" style="margin-bottom: 20px;">
                        <h5 class="card-title" style="font-size: 30px; color: black;">$<%: articulo.precio_a  %></h5>
                        <p class="card-text" style="font-size: 30px; color: black;"><strong><%:articulo.marca_a.Nombre%></strong></p>
                    <p class="card-text" style="font-size: 30px; color: black;"><strong><%:articulo.categoria_a.nombre_categoria%></strong></p>
                    </div>
                </center>
            </div>
        </div>
    
         <%

             } %>

    </div>
</asp:Content>
