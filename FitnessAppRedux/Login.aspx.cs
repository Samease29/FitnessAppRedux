using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessAppRedux
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            int login = Utilities.SqlQueries.loginUser(textUser.Text, textPass.Text);
            if(login == 1)
            {
                Response.Redirect("~/ProfilePage.aspx");
            }
            else
            {
                textUser.Text = "";
                textPass.Text = "";
                labelMsg.Text = "Invalid username/password";
            }
        }

        protected void buttonUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CreateUser.aspx");
        }
    }
}