using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FitnessAppRedux.Utilities;

namespace FitnessAppRedux
{
    public partial class SettingsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == TextBox2.Text)
            {
                if (SqlQueries.updatePassword(TextBox4.Text, TextBox1.Text, TextBox3.Text) == 1)
                {
                    Label1.Text = "Password successfully updated.";
                }
                else 
                {
                    Label1.Text = "Failed to update password.";
                }

            }
            else
            {
                Label1.Text = "Failed to update password.";
            }

        }

    }
}