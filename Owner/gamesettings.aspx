<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="gamesettings.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:FileUpload ID="FileUpload1" runat="server" ForeColor="Black" Height="29px" />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#000099" OnClick="Button1_Click" Text="Upload Images" Width="127px" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Black"></asp:Label>
    <br />
</asp:Content>

