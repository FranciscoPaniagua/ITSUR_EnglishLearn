<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="CatalogoUsuarios.aspx.cs" Inherits="IEL.Vistas.CatalogoUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <meta name="viewport" content="width=device-width, initial-scale=1"/>    
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>   
    <link rel="stylesheet" type="text/css" href="CSS/CatalogoUsuariosCSS.css"/>
    <link href="CSS/dataTables.bootstrap4.css" rel="stylesheet" />
    <script src="JS/CatalogoUsuarios.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/Servicios/wsUsuario.asmx" />
            </Services>
    </asp:ScriptManager>

   
 
    <br />
    <table id="tabla" class="table table-striped table-bordered small"
        style="margin: 0 auto; width: 90%;">
    </table>
    <br />
    <div style="text-align:center">
        <div style="display:inline-block">
    <input type="button" value="Agregar Usuario" onclick="agregar()" class="btn-primary"/>
            </div>
        </div>
    <br />
    <%
        Response.Write("<p id='ruta' style='display:none;visibility:hidden;'>"+Convert.ToBase64String(System.IO.File.ReadAllBytes(HttpContext.Current.Server.MapPath("~/Vistas/IMG/Nombre.png")))+"</p>");
         %>
    <script src="JS/CatalogoUsuarios.js"></script>    
</asp:Content>
