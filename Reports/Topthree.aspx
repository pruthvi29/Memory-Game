<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Topthree.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:LoginName ID="LoginName1" runat="server" Font-Bold="True" ForeColor="#009933" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="PlayerName,DateTime" DataSourceID="SqlDataSource1" Font-Bold="True" ForeColor="#009933">
        <Columns>
            <asp:BoundField DataField="Score" HeaderText="Score" SortExpression="Score" />
            <asp:BoundField DataField="PlayerName" HeaderText="PlayerName" ReadOnly="True" SortExpression="PlayerName" />
            <asp:BoundField DataField="DateTime" HeaderText="DateTime" ReadOnly="True" SortExpression="DateTime" />
            <asp:BoundField DataField="LevelCompleted" HeaderText="LevelCompleted" SortExpression="LevelCompleted" />
            <asp:BoundField DataField="LevelQuit" HeaderText="LevelQuit" SortExpression="LevelQuit" />
            <asp:BoundField DataField="QuitSet" HeaderText="QuitSet" SortExpression="QuitSet" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:memorygamedb %>" SelectCommand="SELECT TOP (3) WITH TIES Score, PlayerName, DateTime, LevelCompleted, LevelQuit, QuitSet FROM scores ORDER BY Score DESC"></asp:SqlDataSource>
    <br />
    <br />

</asp:Content>

