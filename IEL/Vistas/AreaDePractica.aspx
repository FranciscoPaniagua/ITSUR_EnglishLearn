<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="AreaDePractica.aspx.cs" Inherits="IEL.Vistas.AreaDePractica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
        <!--
        <asp:Label ID="txtTema" runat="server" Text="Tema"></asp:Label>
        <br />
        <br />
        <asp:Label ID="txtPregunta" runat="server" Text="Pregunta"></asp:Label>
        <br />
        <br />
        <br />
        <div class="radio">
        <asp:RadioButton ID="rdbA" runat="server" Text="Respuesta2" OnCheckedChanged="rdbA_CheckedChanged"/>
        <br />
        <br />
        <asp:RadioButton ID="rdbB" runat="server" Text="Respuesta3" OnCheckedChanged="rdbB_CheckedChanged"/>
        <br />
        <br />
        <asp:RadioButton ID="rdbC" runat="server" Text="Respuesta4" OnCheckedChanged="rdbC_CheckedChanged"/>
        <br />
        <br />
        </div>
        <br />
        <div class="btn-group">
            <asp:Button ID="btnAnterior" runat="server" Text="Anterior" CssClass="btn btn-primary" OnClick="btnAnterior_Click" />                       
            <asp:Button ID="btnSiguiente" runat="server" Text="Siguiente" CssClass="btn btn-primary" OnClick="btnSiguiente_Click"/>            
        </div>
            -->

        <div id="pregunta"> Pregunta</div>
        <br />
        <br />
        <br />
        <div class="radio">
            <input id="rdbA" type="radio" />
        <br />
        <br />
            <input id="rdbB" type="radio" />     
        <br />
        <br />
            <input id="rdbC" type="radio" />
        <br />
        <br />
        </div>
        <br />
        <div class="btn-group">
            <input id="btnAnterior" type="button" value="button" class="btn btn-primary" />
            <input id="btnAnterio" type="button" value="button" class="btn btn-primary" />
            
        </div>
    </div>
</asp:Content>
