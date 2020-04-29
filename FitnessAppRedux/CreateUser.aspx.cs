﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessAppRedux
{
    public partial class CreateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            if(textPass.Text != textConfirm.Text)
            {
                labelMsg.Text = "Passwords do not match!";
                textUser.Text = "";
                textPass.Text = "";
                textConfirm.Text = "";
                textHeight.Text = "";
                textWeight.Text = "";
                textAge.Text = "";
                sexRadioList.SelectedIndex = -1;
                activeRadioList.SelectedIndex = -1;

            }
            else
            {
                double bmr = Utilities.TDEE.Bmr(sexRadioList.SelectedValue, Double.Parse(textWeight.Text), Double.Parse(textHeight.Text), Int32.Parse(textAge.Text));
                double tdee = Utilities.TDEE.getTdee(activeRadioList.SelectedValue, bmr);
                System.Diagnostics.Debug.WriteLine(textUser.Text);
                System.Diagnostics.Debug.WriteLine(textPass.Text);
                System.Diagnostics.Debug.WriteLine(Int32.Parse(textHeight.Text));
                System.Diagnostics.Debug.WriteLine(Int32.Parse(textWeight.Text));
                System.Diagnostics.Debug.WriteLine(sexRadioList.SelectedValue);
                System.Diagnostics.Debug.WriteLine(Int32.Parse(textAge.Text));
                System.Diagnostics.Debug.WriteLine(Convert.ToInt32(Math.Floor(tdee)));
                Utilities.SqlQueries.createUser(textUser.Text, textPass.Text, Int32.Parse(textHeight.Text), Int32.Parse(textWeight.Text), sexRadioList.SelectedValue, Int32.Parse(textAge.Text), Convert.ToInt32(Math.Floor(tdee)));
                labelMsg.ForeColor = System.Drawing.Color.Green;
                textUser.Text = "";
                textPass.Text = "";
                textConfirm.Text = "";
                textHeight.Text = "";
                textWeight.Text = "";
                textAge.Text = "";
                sexRadioList.SelectedIndex = -1;
                activeRadioList.SelectedIndex = -1;
                labelMsg.Text = "User created!";
            }
        }
    }
}