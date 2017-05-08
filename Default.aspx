<%@ Page Title="Level-1" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  
    <asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            Clicks:
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            &nbsp;&nbsp;&nbsp; Time:
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" Text="0"></asp:Label>
            &nbsp;&nbsp;&nbsp; Set:
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            &nbsp;Score:
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LoginName ID="LoginName1" runat="server" EnableViewState="False" />
            &nbsp;&nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LoginStatus ID="LoginStatus1" runat="server" Font-Bold="True" ForeColor="#CCFFFF" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" BackColor="Yellow" Height="80px" OnClick="ImageButton1_Click" Width="80px" />
            &nbsp;<asp:ImageButton ID="ImageButton2" runat="server" BackColor="Yellow" Height="80px" OnClick="ImageButton2_Click" Width="80px" />
            <br />
            <asp:ImageButton ID="ImageButton3" runat="server" BackColor="Yellow" Height="80px" OnClick="ImageButton3_Click" Width="80px" />
            &nbsp;<asp:ImageButton ID="ImageButton4" runat="server" BackColor="Yellow" Height="80px" OnClick="ImageButton4_Click" Width="80px" />
            <br />
            <br />
            <asp:Button ID="Quit" runat="server" Font-Bold="True" ForeColor="#0000CC" Height="31px" OnClick="Quit_Click" Text="Quit" Width="91px" Font-Size="12pt" />
            &nbsp;
            <asp:Button ID="nextlevel" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#000099" Height="32px" OnClick="nextlevel_Click" Text="Next Level" Width="91px" />
            <br />
            <asp:Timer ID="Timer1" runat="server" Interval="500" OnTick="Timer1_Tick">
            </asp:Timer>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:memorygamedb %>" DeleteCommand="DELETE FROM [scores] WHERE [PlayerName] = @original_PlayerName AND [DateTime] = @original_DateTime AND [LevelCompleted] = @original_LevelCompleted AND [LevelQuit] = @original_LevelQuit AND [QuitSet] = @original_QuitSet AND [Score] = @original_Score" InsertCommand="INSERT INTO [scores] ([PlayerName], [DateTime], [LevelCompleted], [LevelQuit], [QuitSet], [Score]) VALUES (@PlayerName, @DateTime, @LevelCompleted, @LevelQuit, @QuitSet, @Score)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [scores]" UpdateCommand="UPDATE [scores] SET [LevelCompleted] = @LevelCompleted, [LevelQuit] = @LevelQuit, [QuitSet] = @QuitSet, [Score] = @Score WHERE [PlayerName] = @original_PlayerName AND [DateTime] = @original_DateTime AND [LevelCompleted] = @original_LevelCompleted AND [LevelQuit] = @original_LevelQuit AND [QuitSet] = @original_QuitSet AND [Score] = @original_Score">
                <DeleteParameters>
                    <asp:Parameter Name="original_PlayerName" Type="String" />
                    <asp:Parameter Name="original_DateTime" Type="DateTime" />
                    <asp:Parameter Name="original_LevelCompleted" Type="Int32" />
                    <asp:Parameter Name="original_LevelQuit" Type="Int32" />
                    <asp:Parameter Name="original_QuitSet" Type="Int32" />
                    <asp:Parameter Name="original_Score" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="PlayerName" Type="String" />
                    <asp:Parameter Name="DateTime" Type="DateTime" />
                    <asp:Parameter Name="LevelCompleted" Type="Int32" />
                    <asp:Parameter Name="LevelQuit" Type="Int32" />
                    <asp:Parameter Name="QuitSet" Type="Int32" />
                    <asp:Parameter Name="Score" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="LevelCompleted" Type="Int32" />
                    <asp:Parameter Name="LevelQuit" Type="Int32" />
                    <asp:Parameter Name="QuitSet" Type="Int32" />
                    <asp:Parameter Name="Score" Type="Int32" />
                    <asp:Parameter Name="original_PlayerName" Type="String" />
                    <asp:Parameter Name="original_DateTime" Type="DateTime" />
                    <asp:Parameter Name="original_LevelCompleted" Type="Int32" />
                    <asp:Parameter Name="original_LevelQuit" Type="Int32" />
                    <asp:Parameter Name="original_QuitSet" Type="Int32" />
                    <asp:Parameter Name="original_Score" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </ContentTemplate>
</asp:UpdatePanel>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 

</asp:Content>

