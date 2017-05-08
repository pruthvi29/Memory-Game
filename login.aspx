<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     
    <title>VVBG Memory Game</title>
    <style type="text/css">
        body
        {
             background-color:white;
                background-image:url('images/back1.jpg');
                background-repeat:repeat;
                text-align:center;
                position: absolute;
            z-index: -1;
            width: 100%; 
            height: 100%;
            left: 8px;
            top: 15px;
        }
        #one{
             
                text-align:center;
        }
        p, h3
        {
            color:white;
            text-align: center;
            font-size:large;
            height: 21px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id ="one">
   <p>VVGB Memory Game</p>
       <p> Spring -2015<br /></p>
      <p> Team Members:
        Sai Dinesh Vallamsetti<br />
        Shiva Vontela<br />
        Pruthvi Raj Gourwar<br />
        Praharsha Bollam
         </p>
        <p> &nbsp;</p>
        <br />
        <asp:Login ID="Login1" runat="server" BackColor="#FFFFCC" ForeColor="#000066" Height="223px"  Width="312px" BorderColor="White" BorderStyle="Outset" CreateUserText="Click here For Direct Access Without Login" CreateUserUrl="~/Default.aspx" Font-Bold="True">
            <CheckBoxStyle BackColor="Red" ForeColor="White" />
        </asp:Login>
        <br />
    </div>
    </form>
</body>
</html>
