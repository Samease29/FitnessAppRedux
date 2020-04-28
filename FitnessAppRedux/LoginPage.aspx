<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="FitnessAppRedux.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 315px">
    <form id="form1" runat="server">
        <div>
        </div>
        <div style="margin-left: 520px">
            <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" Width="299px">
            </asp:Login>
        </div>
    </form>
</body>
</html>
