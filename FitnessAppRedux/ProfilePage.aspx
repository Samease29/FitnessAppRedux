<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="FitnessAppRedux.ProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="pm_styles.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="top">
        <h1>My Profile</h1>
        <p>Edit your settings here.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/RecipeRequest.aspx">Recipe Request Page</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/PhysicalMetrics.aspx">My Metrics</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/SettingsPage.aspx">My Settings</asp:HyperLink>
        </p>
    </div>
        <div id="container">
            <label for="lblUser">Username: </label>
            <asp:TextBox ID="textUser" runat="server"></asp:TextBox>
            <asp:Button ID="buttonUser" runat="server" Text="Get User Info" OnClick="buttonUser_Click"></asp:Button> <br /><br /><br />
            <%--<asp:Label ID="username" runat="server" ></asp:Label> <br /> <br /><br /><br />--%>
            <label for="lblHeight">Height: </label>
            <asp:Label ID="height" runat="server" ></asp:Label><br /> <br /><br /><br />
            <label for="lblWeight">Weight: </label>
            <asp:Label ID="weight" runat="server" ></asp:Label><br /> <br /><br /><br />
            <label for="lblSex">Sex: </label>
            <asp:Label ID="sex" runat="server" ></asp:Label><br /> <br /><br /><br />
            <label for="lblAge">Age: </label>
            <asp:Label ID="age" runat="server" ></asp:Label><br /> <br /><br /><br />
            <label for="lblCalories">Calories: </label>
            <asp:Label ID="calories" runat="server" ></asp:Label><br /> <br /><br /><br />
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
