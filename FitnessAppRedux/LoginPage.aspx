<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="FitnessAppRedux.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="pm_styles.css" />
    <title></title>
</head>
<body style="height: 315px">
    <form id="form1" runat="server">
        <div id="top">
            <h1>Welcome to FitnessApp!</h1>
                <p>Please login.</p>
        </div>
        <div id="container" style="margin-left: 520px">
            <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" Width="400px" Height="180px">
            </asp:Login>
        </div>
    </form>
</body>
</html>
