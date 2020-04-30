using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace FitnessAppRedux.Utilities
{
    public class Helper
    {
        static internal Boolean RegexUserCheck(String username)
        {
            return Regex.IsMatch(username, "^(?=.*a-z])[A-Za-z0-9@$!%*?&]{8,10}$");
        }

        static internal Boolean RegexPassCheck(String password)
        {
            return Regex.IsMatch(password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*0-9)(?=.*[@$!%*?&])[A-Za-z0-9@$!%*?&]{8,10}$");
        }
    }
}