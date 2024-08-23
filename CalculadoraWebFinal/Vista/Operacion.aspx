<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Pagina Maestra/PrincipalMenu.Master" AutoEventWireup="true" CodeBehind="Operacion.aspx.cs" Inherits="CalculadoraWebFinal.Vista.Operacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> Operacion </h1>
               <asp:Label ID="lblCodigo" runat="server" Text="Código Usuario:"></asp:Label>
            <asp:TextBox ID="TextCodigo" runat="server"></asp:TextBox>
            <asp:Label ID="lblOperacion" runat="server" Text="Operación:"></asp:Label>
            <asp:TextBox ID="TextOperacion" runat="server"></asp:TextBox>
            <asp:Label ID="lblResultado" runat="server" Text="Resultado:"></asp:Label>
            <asp:TextBox ID="TextResultado" runat="server"></asp:TextBox>
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar Operación" OnClick="btnAgregar_Click" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True"></asp:GridView>
</asp:Content>
