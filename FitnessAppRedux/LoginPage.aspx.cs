using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using FitnessAppRedux.Utilities;

namespace FitnessAppRedux
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool successfulAuthentication = AuthenticationMethod(Login1.UserName, Login1.Password);
            e.Authenticated = successfulAuthentication;
            //Boolean passed = e.Authenticated;
            //if (passed)
                Server.Transfer("/PhysicalMetrics.aspx");
        }

        private bool AuthenticationMethod(String username, String password)
        {
            String against = "^(?=.*?[A - Z])(?=.*?[a - z])(?=.*?[0 - 9])(?=.*?[#?!@$%^&*-]).{8,}$";
            String test = "^";
            if (Validate(username, "^(?=.*?[0 - 9a - zA - Z@._]{ 4,32})", "(?=.*?[\\;<>]{1,})") && Validate(password, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[!@#$()%&_^*/{}[]]{2,}).{12,24}$", "(?=.*[\\;<>]{1,})"))
            {
                if (Helper.login_Query(username, password))
                {
                    return true;
                }
            }
            return false;
        }
        private Boolean Validate(String validateText, String patternToMatch, String cannotContain) 
        {
            return Regex.IsMatch(validateText, patternToMatch);//&& !Regex.IsMatch(validateText,cannotContain);
        }
    }
}