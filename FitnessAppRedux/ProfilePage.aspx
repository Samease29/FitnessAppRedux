<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="FitnessAppRedux.ProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="pm_styles.css" />
    <title></title>
</head>
<body>
    <div id="top">
        <h1>My Profile</h1>
        <p>Edit your settings here.</p>
    </div>
    <form id="form1" runat="server">
        <div id="container">
            <div id="main">
                <label for="username">Username: </label>
        <asp:TextBox ID="username" runat="server" ></asp:TextBox>
        <label for="height">Height: </label>
        <asp:TextBox ID="height" runat="server" Width="121px"></asp:TextBox>
        <label for="weight">Weight: </label>
        <asp:TextBox ID="weight" runat="server"></asp:TextBox>
        <label for="sex">Sex: </label>
        <asp:TextBox ID="sex" runat="server"></asp:TextBox>
        <label for="age">Age: </label>
        <asp:TextBox ID="age" runat="server"></asp:TextBox>
        <label for="calories">Calories: </label>
        <asp:TextBox ID="caloriesText" runat="server"></asp:TextBox>
            </div>
        </div>
        
        <div>       
            
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Recipes!" />
        </div>
        <div style="margin-left: 280px">
            <br />
            <br />
            <asp:ListBox ID="profileResultsBox" runat="server" Height="225px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="600px" AutoPostBack="True"></asp:ListBox>
            <asp:Image ID="foodImage" runat="server" ImageUrl="https://spoonacular.com/images/spoonacular-logo-b.svg" />
        </div>
    </form>
</body>
</html>
