<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="insert.aspx.cs" Inherits="TUDAI.insert" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Nueva noticia</h2>

    <div class="form-group">
        <asp:TextBox ID="txt_titulo" runat="server" placeholder="Titulo de la noticia" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:TextBox ID="txt_cuerpo" runat="server" TextMode="MultiLine" Columns="30" Rows="6" placeholder="Cuerpo de la noticia" CssClass="form-control"></asp:TextBox>
    </div>
    <p>
        <asp:Calendar ID="date_fecha" runat="server" ></asp:Calendar>
    </p>
    <div class="form-group">
        <asp:Button ID="btn_submit" runat="server" OnClick="Publicar_Noticia" Text="Publicar" CssClass="btn btn-default"/>
    </div>

    <asp:Label Text="" ID="lbl_resultado" runat="server" ></asp:Label>
</asp:Content>
