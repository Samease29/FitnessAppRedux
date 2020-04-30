<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FitnessAppRedux.Login" %>

<!DOCTYPE html>  
  

<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">
    <link rel="stylesheet" href="pm_styles.css" />
    <title>Login</title>
</head>

<body>  

    <form id="form1" runat="server">
        <div id="top">
            <h1>Login</h1>
        </div>
        <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="label5" runat="server" Text="Username: "></asp:Label> </td>
                <td>
                    <asp:TextBox ID="textUser" runat="server"></asp:TextBox> </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="label6" runat="server" Text="Password: "></asp:Label> </td>
                <td>
                    <asp:TextBox ID="textPass" runat="server" TextMode="Password"></asp:TextBox> </td>
            </tr>
            <tr>
                <td><asp:Button ID="Button2" runat="server" Text="Login" OnClick="Button2_Click1"></asp:Button></td>
                <td><asp:Button ID="buttonUser" runat="server" Text="New User?" OnClick="buttonUser_Click"></asp:Button></td>
            </tr>
            <tr>
                <td><asp:Label ID="labelMsg" ForeColor="red" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
        </div>
    </form>
</body>  

</html>  
