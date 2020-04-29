using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessAppRedux.Utilities
{
    public class TDEE
    {
        public static double Bmr(string sex, double pound, double inch, int age)
        {
            double kg = pound * 0.453592;
            double cm = inch * 2.54;
            double bmr = 0;
            //if-else statement can change but the calculations are there 76.203456 172.72
            if (sex.Equals("M"))
            {
                bmr = (10 * kg) + (6.25 * cm) - (5 * age) + 5;
            }
            else if (sex.Equals("F"))
            {
                bmr = (10 * kg) + (6.25 * cm) - (5 * age) - 161;
            }
            return bmr;
        }

        public static double getTdee(string activity, double bmr)
        {
            //Sedentary(little to no exercise + work a desk job) = 1.2
            //Lightly Active(light exercise 1 - 3 days / week) = 1.375
            //Moderately Active(moderate exercise 3 - 5 days / week) = 1.55
            //Very Active(heavy exercise 6 - 7 days / week) = 1.725
            //Extremely Active(very heavy exercise, hard labor job, training 2x / day) = 1.9

            //if-else statement can change but the calculations are there
            //switch statement is technically more efficient but the low number of circumstantials doesn't make much of a difference
            double tdee = 0;
            if (activity.Equals("s"))
            {
                tdee = 1.2 * bmr;
            }
            else if (activity.Equals("l"))
            {
                tdee = 1.375 * bmr;
            }
            else if (activity.Equals("m"))
            {
                tdee = 1.55 * bmr;
            }
            else if (activity.Equals("h"))
            {
                tdee = 1.725 * bmr;
            }
            else if (activity.Equals("e"))
            {
                tdee = 1.9 * bmr;
            }
            return tdee;
        }
    }
}