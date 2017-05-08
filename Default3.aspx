<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            Clicks:
            <asp:Label ID="Label1" runat="server"></asp:Label>
            &nbsp;Time:
            <asp:Label ID="Label2" runat="server" Text="0"></asp:Label>
            &nbsp;Set:
            <asp:Label ID="Label3" runat="server"></asp:Label>
            &nbsp;Score:
            <asp:Label ID="Label4" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LoginName ID="LoginName1" runat="server" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
<br />
            <asp:ImageButton ID="ImageButton1" runat="server" BackColor="White" Height="80px" Width="80px" OnClick="ImageButton1_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton2" runat="server" BackColor="White" Height="80px" Width="80px" OnClick="ImageButton2_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton3" runat="server" BackColor="White" Height="80px" Width="80px" OnClick="ImageButton3_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton4" runat="server" BackColor="White" Height="80px" Width="80px" OnClick="ImageButton4_Click" />
            <br />
            <asp:ImageButton ID="ImageButton5" runat="server" BackColor="White" Height="80px" Width="80px" OnClick="ImageButton5_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton6" runat="server" BackColor="White" Height="80px" Width="80px" OnClick="ImageButton6_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton7" runat="server" BackColor="White" Height="80px" Width="80px" OnClick="ImageButton7_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton8" runat="server" BackColor="White" Height="80px" Width="80px" OnClick="ImageButton8_Click" />
            <br />
            <asp:ImageButton ID="ImageButton9" runat="server" BackColor="White" Height="80px" Width="80px" OnClick="ImageButton9_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton10" runat="server" BackColor="White" Height="80px" Width="80px" OnClick="ImageButton10_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton11" runat="server" BackColor="White" Height="80px" Width="80px" OnClick="ImageButton11_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton12" runat="server" BackColor="White" Height="80px" Width="80px" OnClick="ImageButton12_Click" />
            <br />
            <asp:ImageButton ID="ImageButton13" runat="server" BackColor="White" Height="80px" Width="80px" OnClick="ImageButton13_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton14" runat="server" BackColor="White" Height="80px" Width="80px" OnClick="ImageButton14_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton15" runat="server" BackColor="White" Height="80px" Width="80px" OnClick="ImageButton15_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton16" runat="server" BackColor="White" Height="80px" Width="80px" OnClick="ImageButton16_Click" />
            <br />
            <br />
            <br />
            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
            </asp:Timer>
<br />
<br />
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
   
</asp:Content>

