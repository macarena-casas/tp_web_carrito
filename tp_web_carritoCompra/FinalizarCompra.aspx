<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="FinalizarCompra.aspx.cs" Inherits="tp_web_carritoCompra.FinalizarCompra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <center>

                <div class="row" style="margin-top: 5%; margin-bottom: 2%; justify-content: center;">

            <h1 scope="col" style="color: blue; width: 600%;"><strong>¡COMPRA REALIZADA CON EXITO!</strong></h1>
                 </div>
                    </center>

            <div class="row" style="margin-top: 5%; margin-bottom: 2%; justify-content: center;">
                <img src="https://umh2809.umh.es/files/2016/05/OK-150x150.png" alt="empty cart" style="width: 20%; height: 20%;">
            </div>
        </div>
        <center>

            <div class="row" style="margin-top: 5%; margin-bottom: 2%; justify-content: center;">

                <h2 scope="col" style="color: blue; width: 600%;"><strong>¡MUCHAS GRACIAS POR ELEGIRNOS!</strong></h2>
            </div>
            <div class="btn-container" style="display: flex; justify-content: center; padding-bottom: 40px;">
        <a href="<%: ResolveUrl("~/Default.aspx") %>" class="btn btn-outline-light btn-lg" style="font-weight: bold; border-color: dimgray; color: black; background-color: seagreen;"><strong>Realizar otra Compra</strong></a>
    </div>
    </div>


</asp:Content>
