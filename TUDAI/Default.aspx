<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TUDAI.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>MiNombre</h1>
    <asp:Label ID="lbl_nombre" CssClass="" Text="Minombre" runat="server"></asp:Label>
    <h2>Noticias</h2>
     
    <asp:ScriptManager EnablePartialRendering="true" ID="ScriptManager1" runat="server" />
    <asp:UpdatePanel runat="server" ID="updatePanel1" UpdateMode="Conditional">
    <ContentTemplate>
       <div class="form-group col-md-4">
        <asp:TextBox ID="txt_busqueda" placeholder="Ingrese un autor" CssClass="form-control " runat="server"></asp:TextBox>
        <asp:Button ID="btn_filtrar" CssClass="btn btn-default" Text="Buscar" runat="server" OnClick="btn_filtrar_Click" />
    </div>
    
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
          <asp:boundfield datafield="autor"
            convertemptystringtonull="true"
            headertext="Autor"/>
          <asp:boundfield datafield="id_categoria"
            convertemptystringtonull="true"
            headertext="ID Categoría"/>
          <asp:hyperlinkfield
            text="Editar"          
            datatextformatstring="{0:c}"
            datanavigateurlfields="id"
            datanavigateurlformatstring="~\alta_noticia.aspx?id={0}"          
            headertext="Editar"
            target="_blank" />

        </columns>

    </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
