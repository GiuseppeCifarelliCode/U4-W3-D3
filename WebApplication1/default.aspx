<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Effettua l'accesso!</h3>
    <label for="username" class="mt-2">Username:</label>
    <asp:TextBox ID="username" runat="server"></asp:TextBox>
    <label for="password" class="mt-2">Password:</label>
    <asp:TextBox ID="password" runat="server" TextMode="Password" ></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn btn-primary my-2" OnClick="Button1_Click" />

    <div id="errorMessage" runat="server" class="alert alert-danger">
        <p>Dati non validi! Riprova</p>
    </div>
</asp:Content>
