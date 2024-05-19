<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="FinalizarCompra.aspx.cs" Inherits="tp_web_carritoCompra.FinalizarCompra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <center>

                <div class="row" style="margin-top: 5%; margin-bottom: 2%; justify-content: center;">

                    <h1 scope="col" style="color: seagreen; width: 600%;"><strong>¡COMPRA REALIZADA CON EXITO!</strong></h1>
                </div>
            </center>

            <div class="row" style="margin-top: 5%; margin-bottom: 2%; justify-content: center;">
                <img src="https://umh2809.umh.es/files/2016/05/OK-150x150.png" alt="empty cart" style="width: 20%; height: 20%;">
            </div>
        </div>
        <center>

            <div class="row" style="margin-top: 5%; margin-bottom: 2%; justify-content: center;">

                <h2 scope="col" style="color: seagreen; width: 600%;"><strong>¡MUCHAS GRACIAS POR ELEGIRNOS!</strong></h2>
            </div>
            <div>
                <asp:Button ID="btnComprar" runat="server" Text="Realizar otra Compra" OnClick="btnComprar_Click" CommandArgument='<%# Eval("articulo.codigo_a") %>'
                    class="btn btn-outline-info text-dark text-decoration-none" Style="font-weight: bold; border-color: white; font-size: 25px;" />
                
            </div>
            <br />  
            <br />  
    </div>

</asp:Content>
