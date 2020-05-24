<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="PersonalizacionUsuario.aspx.cs" Inherits="IEL.Vistas.PersonalizacionUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1"/>    
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>          
      <link rel="stylesheet" type="text/css" href="CSS/CSSPersonalizacionUsuario.css"/>
       <script src="JS/PersonalizacionUsuario.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Services>
            <asp:ServiceReference Path="~/Servicios/wsUsuario.asmx"/>
        </Services>
    </asp:ScriptManager>

    <div id="centrarExterna">
    <div id="centrarInterna">
    <div class="fondoencabezado">
        <h1 id="privilegio" class="letraformato">Usuario </h1>
     </div>
    
    <div class="container" >    
        <img id="imgUsuario"  src="/Vistas/IMG/userHombre.jpg" class="img-circle" alt="Imagen no disponible"/><br />   
        <button type="button" id="btnGuardarImg"  class="btn btn-default" onclick="salirImagen()">Cambiar Avatar</button> 
    </div>
    <br />    
    <div style="height: 156px">    
        <label id="lblUsuario"  class="label label-default">El Pepe</label><br />
        <label id="lblCorreo"   class="label label-default">ElPepeCorreos@gmail.com</label><br /><br />        
        <input type="text" id="txtNuevaContrasena"  placeholder="Nueva Contraseña" class="form-control"/>
        <br />        
        <button type="button" id="btnGuardar"  class="btn btn-primary" onclick="cambiarPassword()">Cambiar Contraseña</button><br />    
    </div>           
        </div>
        </div>
    <script src="JS/PersonalizacionUsuario.js"></script>
</asp:Content>
