<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Practica.aspx.cs" Inherits="IEL.Vistas.Practica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Services>
            <asp:ServiceReference Path="~/Servicios/wsGramatica.asmx"/>
            <asp:ServiceReference Path="~/Servicios/wsVerbo.asmx"/>
            <asp:ServiceReference Path="~/Servicios/wsSujeto.asmx"/>
            <asp:ServiceReference Path="~/Servicios/wsPractica.asmx" />
        </Services>
    </asp:ScriptManager>
    <div class="text-center">
        <div id="pregunta">Pregunta</div>
        <br />
        <br />
        <br />
        <div class="radio">
            <button  type="button" style="width:200px" class="btn btn-secundary"  id="respuestaA" onclick="rdbA(this)">A. Run</button>          
            <br />
            <br />
            <button  type="button" style="width:200px" id="respuestaB" class="btn btn-secundary" onclick="rdbB(this)">A. Run</button>
            <br />
            <br />
            <button  type="button" style="width:200px" id="respuestaC" class="btn btn-secundary" onclick="rdbC(this)">A. Run</button>
            <br />
            <br />
        </div>
        <br />
        <div class="btn-group">           
            <input id="btnSiguiente" type="button" value="Siguiente" class="btn btn-primary" onclick="siguiente(this)"/>
        </div>
    </div>
    <script src="JS/AreaDePractica.js"></script>
</asp:Content>
