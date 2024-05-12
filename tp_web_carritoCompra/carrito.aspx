
<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="carrito.aspx.cs" Inherits="tp_web_carritoCompra.carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
    <div class="table-responsive">
    <table class="table cart-items" style="text-align: center; vertical-align: middle; width:70% ; margin-left: 15%; margin-right:15%;">
        <thead>
            <tr>
                <th scope="col" style="color: mediumseagreen; width: 50%;"><strong>Producto</strong></th>
                <th scope="col" style="width: 50%;"></th>
                <th scope="col" style="color: mediumseagreen; width: 50%; font:100;"><strong>Precio</strong></th>
                <th scope="col" style="color: mediumseagreen; width: 40%;"><strong>Cantidad</strong></th>
                <th scope="col" style="color: mediumseagreen; width: 50%;"><strong>Subtotal</strong></th>
                <th scope="col" style="color: mediumseagreen; width: 30%;"></th>
            </tr>
        </thead>
           </table>
        </div>


</asp:Content>
