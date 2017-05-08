<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="gamehistory.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:LoginName ID="LoginName1" runat="server" Font-Bold="True" Font-Size="20pt" ForeColor="#FF3300" />
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="PlayerName,DateTime" DataSourceID="SqlDataSource1" ForeColor="#FF3300">
        <Columns>
            <asp:BoundField DataField="PlayerName" HeaderText="PlayerName" ReadOnly="True" SortExpression="PlayerName" />
            <asp:BoundField DataField="DateTime" HeaderText="DateTime" ReadOnly="True" SortExpression="DateTime" />
            <asp:BoundField DataField="LevelCompleted" HeaderText="LevelCompleted" SortExpression="LevelCompleted" />
            <asp:BoundField DataField="LevelQuit" HeaderText="LevelQuit" SortExpression="LevelQuit" />
            <asp:BoundField DataField="QuitSet" HeaderText="QuitSet" SortExpression="QuitSet" />
            <asp:BoundField DataField="Score" HeaderText="Score" SortExpression="Score" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:memorygamedb %>" SelectCommand="SELECT * FROM [scores] WHERE ([PlayerName] = @PlayerName)">
        <SelectParameters>
            <asp:SessionParameter Name="PlayerName" SessionField="user" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />

</asp:Content>

