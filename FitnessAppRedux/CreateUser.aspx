<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="FitnessAppRedux.CreateUser" %>

<!DOCTYPE html>  
  

<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <title></title>  
    <style type="text/css">  
        .auto-style1 {  
            width: 100%;  
        }  
    </style>  
</head>  
<body>  

    <form id="form1" runat="server">
        <h3>Create User</h3>
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
                <td>
                    <asp:Label ID="label1" runat="server" Text="Confirm: "></asp:Label> </td>
                <td>
                    <asp:TextBox ID="textConfirm" runat="server" TextMode="Password"></asp:TextBox> </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="label2" runat="server" Text="Height (in): "></asp:Label> </td>
                <td>
                    <asp:TextBox ID="textHeight" runat="server"></asp:TextBox> </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="label3" runat="server" Text="Weight (lb):  "></asp:Label> </td>
                <td>
                    <asp:TextBox ID="textWeight" runat="server"></asp:TextBox> </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="label4" runat="server" Text="Age: "></asp:Label> </td>
                <td>
                    <asp:TextBox ID="textAge" runat="server"></asp:TextBox> </td>
            </tr>
             <tr>
                <td><asp:Label ID="label7" runat="server" Text="Activity: "></asp:Label></td>
                <td><asp:RadioButtonList ID="activeRadioList" runat="server">
                    <asp:ListItem Value="s">Sedentary</asp:ListItem>
                    <asp:ListItem Value="l">Light</asp:ListItem> 
                    <asp:ListItem Value="m">Moderate</asp:ListItem>
                    <asp:ListItem Value="h">Heavy</asp:ListItem>
                    <asp:ListItem Value="e">Extreme</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="labelSex" runat="server" Text="Sex: "></asp:Label></td>
                <td><asp:RadioButtonList ID="sexRadioList" runat="server">
                    <asp:ListItem Value="M">M</asp:ListItem>
                    <asp:ListItem Value="F">F</asp:ListItem> </asp:RadioButtonList>
                </td>
            </tr>

             <tr>
                <td><asp:Label ID="labelMsg" ForeColor="red" runat="server" Text=""></asp:Label></td>
            </tr>
             <tr>
                <td><asp:Button ID="Button2" runat="server" Text="Create User" OnClick="Button2_Click1"></asp:Button></td>
            </tr>
        </table>
        </div>
    </form>
</body>  

</html>  
