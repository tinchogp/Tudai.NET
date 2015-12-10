<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TUDAI.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>MiNombre</h1>
    <asp:Label CssClass="" Text="Minombre" runat="server"></asp:Label>
    <h2>Noticias</h2>

    <asp:GridView ID="gvNoticias" runat="server" CssClass="table table-hover" GridLines="None" BorderStyle="None"
        AutoGenerateColumns="false">
        
        <columns>
          <asp:boundfield datafield="id"
            readonly="true"      
            headertext="id"/>
          <asp:boundfield datafield="titulo"
            convertemptystringtonull="true"
            headertext="Titulo"/>
          <asp:boundfield datafield="fecha"
            convertemptystringtonull="true"
            headertext="Fecha"/>
          <asp:boundfield datafield="cuerpo"
            convertemptystringtonull="true"
            headertext="Cuerpo"/>
          <asp:boundfield datafield="id_categoria"
            convertemptystringtonull="true"
            headertext="ID Categoría"/>
          <asp:hyperlinkfield text="Editar"
            navigateurl="~\alta_noticia.aspx"            
            headertext="Editar"
            target="_blank" />

        </columns>

    </asp:GridView>

</asp:Content>
