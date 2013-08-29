<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="calculadora.ascx.cs" Inherits="WebApplication2.WebUserControl1" %>
 <asp:TextBox ID="txtentrada" runat="server"></asp:TextBox>
    <asp:Button ID="btnsumar" runat="server" Text="Button" 
        onclick="btnsumar_Click" />
    <asp:Label ID="lblresultado" runat="server" Text="Label"></asp:Label>

    <asp:DropDownList ID="DropDownList1" runat="server" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
     <asp:ListItem Value="decimal">decimal</asp:ListItem>
     <asp:ListItem Value="binario">binario</asp:ListItem>
    </asp:DropDownList>