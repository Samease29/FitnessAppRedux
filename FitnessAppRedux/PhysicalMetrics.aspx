<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhysicalMetrics.aspx.cs" Inherits="FitnessAppRedux.PhysicalMetrics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="pm_styles.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div id="top">
         <h1>My Physical Metrics</h1>
            <p>Enter your physical metrics here so they can be submitted to your profile.</p>
          </div>
        <div id ="container">
            <div id="main">
                <label for="height">Height (in inches):</label>
                <asp:TextBox ID="height" runat="server"></asp:TextBox>
                <br />
                <label for="weight">Weight (in pounds):</label>
                <asp:TextBox ID="weight" runat="server" TabIndex="1"></asp:TextBox>
                <br />
                <label for="birthday">Birthday:</label>
                <asp:TextBox ID="birthday" runat="server" TextMode="Date" TabIndex="2"></asp:TextBox>
                <br />
                <p>What meals do you typically eat everyday? Select all that apply.</p>
                <br />
                <label for="breakfast">Breakfast:</label>
                <asp:CheckBox ID="breakfast" runat="server" TabIndex="3" />
                <br />
                <label for="lunch">Lunch:</label>
                <asp:CheckBox ID="lunch" runat="server" TabIndex="4" />
                <br />
                <label for="dinner">Dinner:</label>
                <asp:CheckBox ID="dinner" runat="server" TabIndex="5" />
                <br />
                <asp:Button ID="submit" runat="server" Text="Submit" TabIndex="6" OnClick="submit_Click" />
                <asp:Button ID="reset" runat="server" Text="Reset" TabIndex="7" OnClick="reset_Click" />
            </div>
        </div>
    </form>
</body>
</html>