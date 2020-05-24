<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="EstadisticasForm.aspx.cs" Inherits="IEL.Vistas.EstadisticasForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1"/>

    <link rel="stylesheet" type="text/css" href="CSS/estadisticas.css"/>
    <script src="../Scripts/jquery-3.3.1.js"></script>
    <script src="JS/Estadisticas.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Services>
            <asp:ServiceReference Path="~/Servicios/wsUsuario.asmx"/>
            <asp:ServiceReference Path="~/Servicios/wsPreguntaContestadaPorUsuario.asmx" />
            <asp:ServiceReference Path="~/Servicios/wsPreguntaPorTema.asmx" />
             <asp:ServiceReference Path="~/Servicios/wsPractica.asmx" />
        </Services>
    </asp:ScriptManager>
    <div class="panel-group"
        style="
        font-family :'Indie Flower', cursive;
  font-size:37px;
   background:linear-gradient(to bottom,#69E8B2 0%,#8FF4C9 100%);  
    color:black;
    padding-top:30px;
    top:-20px;
    position:relative;
    border-color:#1B3280;
    text-align:center;
   
        ">
  <center><p>Estadisticas </p></center>

</div>
    <br />
    <div class="panel-group" style="
       
    text-decoration-line:none;
    font-weight:bold;
    color:#73a0e7;
    font-size:40px;
    font-family :'Indie Flower', cursive;
        ">
         <p id="txtNombreAlumno" style="padding-left:100px;">Eusebio Rodríguez
        </p>
        
    </div>
    <div style="padding-left:100px" class="panel-group divContenido">
        <img class="img-responsive" ID="imgProgress"  src="/Vistas/IMG/learn.png" />
        <p id="txtSimplePresent" style="text-decoration-color:#69e882; text-decoration-line:underline;" >Simple present: 0%  </p>
        <progress id="barraPresente" value="0" max="100" style="width:270px"></progress>
        <br />
        <p id="txtSimplePast" style="text-decoration-color:#69e882; text-decoration-line:underline;">Simple past: 0%</p>
        <progress id="barraPasado" value="0" max="100" style="width:270px;" ></progress>
        <br />
        <p id="txtVerbs" style="text-decoration-color:#69e882; text-decoration-line:underline;">Verbs: 0%</p>
        <progress  id="barraVerbo" value="0" max="100" style="width:270px;"></progress>
        <br />
        <p id="txtVocabulario" style="text-decoration-color:#69e882; text-decoration-line:underline;">Vocabulary: 0%</p>
        <progress id="barraVocabulario" value="0" max="100"  style="width:270px;"></progress>
       
    </div>

    
    <div class="panel-group container-fluid" id="barraDiv">
         <br />
        
        <p class="text-right" style="font-family :'Indie Flower', cursive;
    font-size:50px;
    color:#73a0e7;
    padding-right:100px;
    padding-top:-100px;
    font-weight:bolder;
    
    display:block!important;
-webkit-transition:-webkit-transform 0.5s ease-out;
-moz-transition:-moz-transform 0.5s ease-out;
-o-transition:-o-transform 0.5s ease-out;
-ms-transition:-ms-transform 0.5s ease-out;
transition:transform 0.5s ease-out;

    " id="txtAvance">Avance: 0%</p>
        
        <progress  id="barProgress" value="0" max="100" style="float:right; padding-right:400px; height:30px; width:300px;"></progress>

       
    </div>
   
    <br />
      <br />
   <!-- <div class="panel-group container-fluid percetActs" >
       <div style="float:right">
             <p id="tittleActs" >
                Porcentaje de actividades
            </p>
                
              <p >
                  Completar oraciones: 70%
                   
              </p>
               
              <p >
                  Relacionar verbos: 80%
                  
              </p>
                  
              <p >
                  ordenar palabras: 80%
                   
              </p>
       </div>
                       
    </div> -->
    <br />
    <br />

</asp:Content>
