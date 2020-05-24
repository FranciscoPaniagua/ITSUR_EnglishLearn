<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="QuizForm.aspx.cs" Inherits="IEL.Vistas.QuizForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1"/>    
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>          
      <link rel="stylesheet" type="text/css" href="CSS/CSSQuiz.css"/>
       <script src="JS/quiz.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Services>
            <asp:ServiceReference Path="~/Servicios/wsQuiz.asmx"/>
        </Services>
    </asp:ScriptManager>

    <div  id="titulo">
        <h1 style="padding-bottom:20px;">Quiz</h1>
       
        <!--<button id="logear" runat="server"></button>-->
        
        
    </div>
    <br />
        
    <div id="centrarcoloreada">
      <div class="btn-group" id="coloreada"> 
          <button type="button" style="height:40px; width:70px" class="contestadasColor" id="color1"></button>
            <button type="button" style="height:40px; width:70px" class="contestadasColor" id="color2"></button>
           <button type="button" style="height:40px; width:70px" class="contestadasColor" id="color3"></button>
            <button type="button" style="height:40px; width:70px" class="sinContestarColor" id="color4"></button>
           <button type="button" style="height:40px; width:70px" class="sinContestarColor" id="color5"></button>
            <button type="button" style="height:40px; width:70px" class="sinContestarColor" id="color6"></button>
           <button type="button" style="height:40px; width:70px" class="sinContestarColor" id="color7"></button>
            <button type="button" style="height:40px; width:70px" class="sinContestarColor" id="color8"></button>
          <button type="button" style="height:40px; width:70px" class="sinContestarColor" id="color9"></button>
            <button type="button" style="height:40px; width:70px" class="sinContestarColor" id="color10"></button>           
        </div></div>
    <br />
    <br />                    
        <div class="container-fluid" id="textopregunta" style="font-size:25px;font-weight:bold;"><p>Seleccione la palabra incorrecta</p>

        </div>
        <br />
         <div id="centraropciones">       
        <div class="btn-group-vertical" >

            <button  type="button" style="width:200px" id="answerA" class="botonRespuesta" onclick="respuestaUsuario(this)">A. Run</button>
            <br />
             <br />
            <button  type="button" id="answerB" class="botonRespuesta" onclick="respuestaUsuario(this)">B. Try</button>
            <br />
             <br />
            <button type="button" style="width:200px" id="answerC" class="botonRespuesta" onclick="respuestaUsuario(this)">C. Slep</button>
            <br />
             <br />
            <button  type="button" style="width:200px" id="answerD" class="botonRespuesta" onclick="respuestaUsuario(this)">D. Wake</button>
            <br />
             <br />
            <button type="button" id="btnNext" style="width:84px" onclick="cambiar()">Next</button>
        </div></div>    
    <script src="JS/quiz.js"></script>    
</asp:Content>
