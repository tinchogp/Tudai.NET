<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="alta_categoria.aspx.cs" Inherits="TUDAI.AltaCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Nueva categoria</h2>
    <div class="form-horizontal">
        <div class="form-group">
            <asp:Label CssClass="control-label col-sm-2" Text="Nombre" AssociatedControlID="txt_nombre" runat="server" >
                <asp:RequiredFieldValidator ControlToValidate="txt_nombre" ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
            </asp:Label>            
            
            <div class="col-sm-10">
                <asp:TextBox ID="txt_nombre" runat="server" placeholder="Nombre de la categoria" CssClass="form-control">
                 </asp:TextBox>                
            </div>
        </div>
    
        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-10">
                <asp:Button ID="btn_submit" runat="server" OnClick="Publicar_Categoria" Text="Publicar" CssClass="btn btn-default"/>
            </div>
        </div>
    </div>
    <asp:Label Text="" ID="lbl_resultado" runat="server" ></asp:Label>
</asp:Content>
