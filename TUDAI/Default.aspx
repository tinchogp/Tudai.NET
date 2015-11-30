<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TUDAI.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Noticias</h2>

    <asp:SqlDataSource ID="NOTICIAS" runat="server"
        ConnectionString="tudaiConnectionString"
        ProviderName="System.Data.SqlClient"
        SelectCommand="SELECT [id],[titulo] FROM [Noticias]">

    </asp:SqlDataSource>

    <asp:GridView ID="NOTICIAS_GRID" runat="server"
        AutoGenerateColumns="true" DataSourceID="NOTICIAS"></asp:GridView>

</asp:Content>
