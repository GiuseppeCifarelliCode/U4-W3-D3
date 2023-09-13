<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="WebApplication1.Clienti.menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="listaPizze" runat="server" CssClass="text-bg-secondary p-2">
        <asp:ListItem Value="margherita" Text="Margherita ($4.00)"></asp:ListItem>
        <asp:ListItem Value="diavola" Text="Diavola ($5.00)"></asp:ListItem>
        <asp:ListItem Value="formaggi" Text="4 Formaggi ($6.00)"></asp:ListItem>
        <asp:ListItem Value="americana" Text="Americana ($6.00)"></asp:ListItem>
    </asp:DropDownList>
    <div>
        <asp:CheckBoxList ID="listaAggiunte" runat="server" RepeatColumns="2" CssClass="border border-2 my-2 text-bg-secondary" CellPadding="10" >
            <asp:ListItem Value="2" Text="Mozz.Bufala ($2.00)"></asp:ListItem>
            <asp:ListItem Value="1" Text="Patatine ($1.00)"></asp:ListItem>
            <asp:ListItem Value="1,5" Text="Salame ($1.50)"></asp:ListItem>
            <asp:ListItem Value="1,5" Text="Salsiccia ($1.50)"></asp:ListItem>
        </asp:CheckBoxList>
    </div>

    <asp:Button ID="addPizza" runat="server" Text="Aggiungi Pizza" CssClass="btn btn-primary my-2" OnClick="addPizza_Click" />
    <asp:Button ID="showTotal" runat="server" Text="Calcola Totale" CssClass="btn btn-warning my-2" OnClick="showTotal_Click" />
    <asp:Label ID="message" runat="server" Text="Pizza Aggiunta!"></asp:Label>

    <div id="listContainer" runat="server" class="border border-2 p-2 text-bg-info">
        <h3 class="text-center">Carrello:</h3>
    </div>
</asp:Content>
