<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            Clicks:
            <asp:Label ID="Label5" runat="server"></asp:Label>
            &nbsp; Time:
            <asp:Label ID="Label6" runat="server" Text="0"></asp:Label>
            &nbsp;Set:
            <asp:Label ID="Label7" runat="server"></asp:Label>
            &nbsp;Score:
            <asp:Label ID="Label8" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LoginName ID="LoginName1" runat="server" />
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" BackColor="#009900" Height="80px" OnClick="ImageButton1_Click" Width="80px" />
            &nbsp;<asp:ImageButton ID="ImageButton2" runat="server" BackColor="#009900" Height="80px" Width="80px" OnClick="ImageButton2_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton3" runat="server" BackColor="#009900" Height="80px" Width="80px" OnClick="ImageButton3_Click" />
            <br />
            <asp:ImageButton ID="ImageButton4" runat="server" BackColor="#009900" Height="80px" Width="80px" OnClick="ImageButton4_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton5" runat="server" BackColor="#009900" Height="80px" Width="80px" OnClick="ImageButton5_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton6" runat="server" BackColor="#009900" Height="80px" Width="80px" OnClick="ImageButton6_Click" />
            <br />
            <asp:ImageButton ID="ImageButton7" runat="server" BackColor="#009900" Height="80px" Width="80px" OnClick="ImageButton7_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton8" runat="server" BackColor="#009900" Height="80px" Width="80px" OnClick="ImageButton8_Click" />
            &nbsp;<asp:ImageButton ID="ImageButton9" runat="server" BackColor="#009900" Height="80px" Width="80px" OnClick="ImageButton9_Click" />
            <br />
            <br />
            <asp:Button ID="Quit" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#000099" Height="33px" OnClick="Quit_Click" Text="Quit" Width="64px" />
            &nbsp;<asp:Button ID="nextlevel" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#000099" Height="33px" OnClick="nextlevel_Click" Text="Next Level" Width="94px" />
            <br />
            <asp:Timer ID="Timer1" runat="server" Interval="500" OnTick="Timer1_Tick">
            </asp:Timer>
        </ContentTemplate>
    </asp:UpdatePanel>
    

</asp:Content>

