<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="CambiarImagen.aspx.cs" Inherits="IEL.Vistas.CambiarImagen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1"/>    
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>          
      <link rel="stylesheet" type="text/css" href="CSS/CSSCambiarImagen.css"/>
       <script src="JS/CambiarImagen.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Services>
            <asp:ServiceReference Path="~/Servicios/wsUsuario.asmx"/>
        </Services>
    </asp:ScriptManager>
    <div id="alinearexterno">
        <div id="alinearinterno">
            <h1>Selecciona un Avatar</h1><br /><br />
            <div class="style_prevu_kit"><img id="imgHombre" src="/Vistas/IMG/userHombre.jpg" onclick="cambiarImg(this)" alt="Imagen no disponible"/></div>
            <div class="style_prevu_kit"><img id="imgMujer" src="/Vistas/IMG/userMujer.jpg" onclick="cambiarImg(this)" alt="Imagen no disponible"/></div>
            <br />
            <br />
            <div id="divVolver" class="container">
                <button id="btnVolver" type="button" onclick="volver()" class="btn btn-primary">Volver</button>
            </div>            
        </div>
    </div>
    <script src="JS/CambiarImagen.js"></script>
</asp:Content>
