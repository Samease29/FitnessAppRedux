<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SettingsPage.aspx.cs" Inherits="FitnessAppRedux.SettingsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="pm_styles.css" />
    <title></title>
</head>
<body style="height: 208px">
    <form id="form1" runat="server">
        <div id="top">
            <h1>Settings</h1>
        </div>
        <div style="margin-top: 15px">
            Settings<br />
            <br />
            Current Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Current Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Re-Enter Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            New Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update Password" Width="116px" />
            <br />

        </div>
    </form>
</body>
</html>
