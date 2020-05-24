<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="IEL.Vistas.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="CSS/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="JS/bootstrap.min.js"></script>
    <style>      
        .logo {
            width: 200px;
        }
        /* Remove the navbar's default margin-bottom and rounded borders */
        .navbar {
            margin-top:0;
            margin-bottom: 0;
            border-radius: 0;
        }
        .jumbotron{
            margin-bottom:0;
        }

        /* Add a gray background color and some padding to the footer */
        footer {
            background-color: #f2f2f2;
            padding: 25px;
        }

        .welcome{
            width:100px;
            height:auto;
            font-size:40px;
            color:black;
            left:0;
            position:relative;
            
        }
        .contenedor{
            width:100%;
            height:auto;
            border-left: 6px solid red;
            border-right: 6px solid red;
            background-color: lightgrey;
            position:absolute;
        }
        .contenedor:hover {
            background-color:darkgrey;
        }

    </style>
</head>
<body>
    <div class="jumbotron">
        <div class="container text-left">
            <img src="IMG/Nombre.png" class="logo"/>
        </div>
    </div>
    <nav class="navbar navbar-inverse">
        <div class="container-fluid">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="#"></a>
            </div>
            <div class="collapse navbar-collapse" id="myNavbar">
                
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="login.aspx">Iniciar Sesión </a></li>
                </ul>
            </div>
        </div>
    </nav>
        <div class="contenedor">
             <div class="welcome">Bienvenidos</div>
        </div>
       
        <br>
        <video autoplay controls src="IMG/IEL.mp4" width="60%"></video>

    
    <br>
    <br>

    <footer class="container-fluid text-center">
        <h5>Acerca de nosotros</h5>
        <p>Somos jovenes como tu interesados en frindarte un servicio mediante IEL un sitio interactivo para aprender ingles.</p>
        <p>Puedes contactarnos mediante el siguinete correo: <b>IEL@itsur.edu.mx</b></p>
    </footer>

</body>
</html>
