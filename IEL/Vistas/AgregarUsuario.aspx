<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="IEL.Vistas.AgregarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1"/>    
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>  
     <link rel="stylesheet" type="text/css" href="CSS/CSSAgregarUsuario.css"/>
    <script src="JS/AgregarUsuario.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/Servicios/wsUsuario.asmx" />
            </Services>
    </asp:ScriptManager>
 <div  id="titulo">
        <h1>Agregar Usuario</h1>
    </div>    
  <div class="form-group entrada">
      <label for="User">User</label>
      <input type="text" class="form-control" id="User" placeholder="User name" />
  </div>
  <div class="form-group entrada">
      <label for="Password">Password</label>
      <input type="password" class="form-control" id="Password" placeholder="password" />
  </div>
 <div class="form-group entrada">
      <label for="Nombre">Nombre</label>
      <input type="text" class="form-control" id="Nombre" placeholder="Nombre" />
  </div>
  <div class="form-group entrada">
      <label for="ApellidoPaterno">Apellido Paterno</label>
      <input type="text" class="form-control" id="ApellidoPaterno"  placeholder="Apellido Paterno"/>
  </div>
  <div class="form-group entrada">
      <label for="ApellidoMaterno">Apellido Materno</label>
      <input type="text" class="form-control" id="ApellidoMaterno" placeholder="Apellido Materno"/>
  </div>
       <div class="form-group entrada">
      <label for="Correo">Correo</label>
      <input type="email" class="form-control" id="Correo" placeholder="Correo"/>
  </div> 
    <div style="text-align:center">
        <div style="display:inline-block">
            <h2>Selecciona un Avatar</h2>
            <br />                
        <div class="style_prevu_kit"><img id="imgHombre" src="/Vistas/IMG/userHombre.jpg" onclick="cambiarAvatar(this)" alt="Imagen no disponible"/></div>
         <div class="style_prevu_kit"><img id="imgMujer" src="/Vistas/IMG/userMujer.jpg" onclick="cambiarAvatar(this)" alt="Imagen no disponible"/></div>
         <br />
         <br />        
    <br />    
    <br />
    <button type="button" class="btn btn-primary" id="btnGuardar" onclick="guardar()">Guardar</button>
        </div>
        </div>
    <script src="JS/AgregarUsuario.js"></script>    
</asp:Content>
