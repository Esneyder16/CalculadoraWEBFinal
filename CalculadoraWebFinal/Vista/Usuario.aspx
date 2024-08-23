<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Pagina Maestra/PrincipalMenu.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="CalculadoraWebFinal.Vista.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Catalogo de Usuario</h1>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label>
    <asp:TextBox ID="TextCodigo" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="TextNombre" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
</asp:Content>
