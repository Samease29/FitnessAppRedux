using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FitnessAppRedux.Utilities;

namespace FitnessAppRedux
{
    public partial class PhysicalMetrics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            //For future use
            /*
            height.Text = "";
            weight.Text = "";
            breakfast.Checked = false;
            lunch.Checked = false;
            dinner.Checked = false;
            DateTime birthdayAsDate = DateTime.ParseExact(birthday.Text, "mm/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            long birthdayAsLong = birthdayAsDate.Ticks;
            long present = DateTime.Now.Ticks;
            long ticksSinceBirth = present - birthdayAsLong;
            double age = ticksSinceBirth / (TimeSpan.TicksPerDay * 365);
            String username = "";//Need to figure out how we're handling knowing who's info to update
            */
                       

        }

        protected void reset_Click(object sender, EventArgs e)
        {
            height.Text = "";
            weight.Text = "";
            birthday.Text = "";
            breakfast.Checked = false;
            lunch.Checked = false;
            dinner.Checked = false;
        }

        protected void breakfast_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}