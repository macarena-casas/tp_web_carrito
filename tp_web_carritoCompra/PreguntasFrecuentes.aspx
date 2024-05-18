<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="PreguntasFrecuentes.aspx.cs" Inherits="tp_web_carritoCompra.PreguntasFrecuentes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="margin-top: 5%; margin-bottom: 2%; justify-content: center;">

        <h1 scope="col" style="color: darkgreen; width: 600%; text-align: center;"><strong>Preguntas Frecuentes</strong></h1>
    </div>

    <div class="accordion accordion-flush" id="accordionpregfrecuentes" style="margin-left: 10%; margin-right: 10%; margin-bottom: 2%;">
        <div class="accordion-item">
            <h2 class="accordion-header" style="color: darkgreen;">
                <button class="accordion-button collapsed" type="button" style="color: darkgreen; font-size: 25px" data-bs-toggle="collapse" data-bs-target="#flush-collapseOne" aria-expanded="false" aria-controls="flush-collapseOne">
                    <strong>¿Como comprar? </strong>
                </button>
            </h2>
            <div id="flush-uno" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
                <div class="accordion-body">
                    <strong>¡Lo Sentimos!</strong>Momentaneamente esta área se encuentra fuera de servicio. Estamos trabajando para brindarle un mejor servicio, disculpe las molestias!.
                </div>
            </div>
        </div>
        <div class="accordion-item">
            <h2 class="accordion-header">
                <button class="accordion-button collapsed" type="button" style="color: darkgreen; font-size: 25px" data-bs-toggle="collapse" data-bs-target="#flush-collapseTwo" aria-expanded="false" aria-controls="flush-collapseTwo">
                    <strong>Cupones y Descuentos </strong>

                </button>
            </h2>
            <div id="flush-dos" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
                <div class="accordion-body">
                    <strong>¡Lo Sentimos!</strong>Momentaneamente esta área se encuentra fuera de servicio. Estamos trabajando para brindarle un mejor servicio, disculpe las molestias!.
                </div>
            </div>
        </div>
        <div class="accordion-item">
            <h2 class="accordion-header" style="color: darkgreen;">
                <button class="accordion-button collapsed" type="button" style="color: darkgreen; font-size: 25px" data-bs-toggle="collapse" data-bs-target="#flush-collapseThree" aria-expanded="false" aria-controls="flush-collapseThree">
                    <strong>Informacion Sobre Productos </strong>
                </button>
            </h2>
            <div id="flush-tres" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
                <div class="accordion-body">
                    <strong>¡Lo Sentimos!</strong>Momentaneamente esta área se encuentra fuera de servicio. Estamos trabajando para brindarle un mejor servicio, disculpe las molestias!.
                </div>
            </div>
        </div>
        <div class="accordion-item">
            <h2 class="accordion-header">
                <button class="accordion-button collapsed" type="button" style="color: darkgreen; font-size: 25px" data-bs-toggle="collapse" data-bs-target="#flush-collapseTwo" aria-expanded="false" aria-controls="flush-collapseTwo">
                    <strong>Cambiar Domicilio de Entrega</strong>

                </button>
            </h2>
            <div id="flush-cuatro" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
                <div class="accordion-body">
                    <strong>¡Lo Sentimos!</strong>Momentaneamente esta área se encuentra fuera de servicio. Estamos trabajando para brindarle un mejor servicio, disculpe las molestias!.
                </div>
            </div>
        </div>
        <div class="accordion-item">
            <h2 class="accordion-header">
                <button class="accordion-button collapsed" type="button" style="color: darkgreen; font-size: 25px" data-bs-toggle="collapse" data-bs-target="#flush-collapseTwo" aria-expanded="false" aria-controls="flush-collapseTwo">
                    <strong>¿Como modificar un pedido? </strong>

                </button>
            </h2>
            <div id="flush-cinco" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
                <div class="accordion-body">
                    <strong>¡Lo Sentimos!</strong>Momentaneamente esta área se encuentra fuera de servicio. Estamos trabajando para brindarle un mejor servicio, disculpe las molestias!.
                </div>
            </div>

        </div>
         <div class="accordion-item">
            <h2 class="accordion-header">
                <button class="accordion-button collapsed" type="button" style="color: darkgreen; font-size: 25px" data-bs-toggle="collapse" data-bs-target="#flush-collapseTwo" aria-expanded="false" aria-controls="flush-collapseTwo">
                    <strong>Documentación para retirar mi pedido </strong>

                </button>
            </h2>
            <div id="flush-seis" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
                <div class="accordion-body">
                    <strong>¡Lo Sentimos!</strong>Momentaneamente esta área se encuentra fuera de servicio. Estamos trabajando para brindarle un mejor servicio, disculpe las molestias!.
                </div>
            </div>

        </div>
    </div>
      <div class="btn-container" style="display: flex; justify-content: center; padding-bottom: 40px;">
        <a href="<%: ResolveUrl("~/Default.aspx") %>" class="btn btn-outline-light btn-lg" style="font-weight: bold; border-color: dimgray; color: black; background-color: seagreen;"><strong>Regresar</strong></a>
    </div>


</asp:Content>
