<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="MaterialDeAprendizaje.aspx.cs" Inherits="IEL.Vistas.MaterialDeAprendizaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1"/>    
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>   
    <link href="CSS/EstilosMaterialDeAprendizaje.css" rel="stylesheet" />
    <script src="JS/MaterialAprendizaje.js"></script>       
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/Servicios/wsTema.asmx" />
                <asp:ServiceReference Path="~/Servicios/wsVerbo.asmx" />
            </Services>
        </asp:ScriptManager>

    <div class="modal fade" id="mostrarmodal" tabindex="-1" role="dialog" aria-labelledby="basicModal" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true"></button>
                    <h3>Bienvenido al material de aprendizaje</h3>
                </div>
                <div class="modal-body">
                    <h4>En esta sección encontraras información que te ayude a comprender mejor la gramatica del ingles</h4>             
                </div>
                <div class="modal-footer">
                    <a href="#" data-dismiss="modal" class="btn btn-danger">Cerrar</a>
                </div>
            </div>
     </div>
 </div>
        
    <div id = "menu">
		<div id = "titulo">
			Temario
		</div>
		<div id = "item_menu">
			<div class="item" id="tema1" onclick="Tema1()">...</div>
			<div class="item" id="tema2" onclick="Tema2()">...</div>
            <div class="item" id="tema4" onclick="Tema3()"></div>
			<div class="item" id="tema3" onclick="tbVerbos()">...</div>
			
			<!--<div class="item" id="tema5" onclick="cambiarInfo5()">...</div>-->
		</div>
	</div>
            
        <div id="cuerpo">
     <div class="container" >
         <div class="row">             
             <div class="col-sm-12" >
                 <p></p>
             </div>
         </div>
         <div class="row">             
             <div class="col-sm-12" ">
                 <h3 class="text-center" id ="tituloTema" style="color:white">Titulo</h3>
             </div>
         </div>

         <!--<div class="row">             
             <div class="col-sm-12" >
                 <p>Lorem ipsum</p>
             </div>
         </div>-->
         
         <div class="container">
             <div class="col-sm-12" id="Contenido"   style="background-color:white;">
                 <p id="ContenidoT1"></p>
                 <div id="ContenedorTabla2"></div>
                 <div id="ContenedorTabla"></div>
                 <p id="ContenidoT2"></p>
                 <br/>
                 <div id="ContenedorTexto"></div>   
             </div>
         </div>
     </div>		
	</div>
          <script src="JS/MaterialAprendizaje.js"></script>                 
</asp:Content>
