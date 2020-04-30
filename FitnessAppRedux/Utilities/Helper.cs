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
            return Regex.IsMatch(username, "^(?=.*a-z])[A-Za-z\d@$!%*?&]{8,10}$");
        }

        static internal Boolean RegexPassCheck(String password)
        {
            return Regex.IsMatch(password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,10}$");
        }
    }
}