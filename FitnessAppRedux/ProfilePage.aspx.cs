using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace FitnessAppRedux
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        static Dictionary<String, String> currentRecipes = new Dictionary<String, String>();//To hold the Strings to display in the list box and the image urls associated

        protected void Page_Load(object sender, EventArgs e)
        {

                
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foodImage.ImageUrl = currentRecipes[profileResultsBox.SelectedValue];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //commented out here but once the page is made we can use this code to start getting data based the profile from the api
            int maxcals = Int32.Parse(calories.Text);//this needs to be changed to whatever actually will parse an int, will change once page is updated
            int mincals = maxcals / 3;
            WebRequest request = WebRequest.Create("https://api.spoonacular.com/recipes/findByNutrients?minCalories=" + mincals + "&maxCalories=" + maxcals + "&number=10&apiKey=a1b8fa50293f4158a5a46e6fc461ae31");
            WebResponse response = request.GetResponse();
            using (Stream datastream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(datastream);// open the stream using a streamreader for easy access
                string responsefromserver = reader.ReadToEnd();// holds the string that is basically the json
                var parseddata = JArray.Parse(responsefromserver);//parses it into a jarray, basically something for us to loop through to get the data out of
                String name, calories, protein, fat, carbs;//These are to be used to store the recipes for database stuff
                name = "";//These all needed to be assigned so we have this gross setup
                calories = "";
                protein = "";
                fat = "";
                carbs = "";
                String[] macrosList;
                Dictionary<String, String[]> recipesToAdd = new Dictionary<string, string[]>();//Holds recipe names with calorie/macro data

                profileResultsBox.Items.Clear();//clear the resultsbox in case someone already made a request and is making another
                string toadd = "";//using this string to build results entries. append on titles and calories
                string imageurl = "";

                foreach (JObject root in parseddata)//loop to pull out the title and calories for each returned recipe
                {
                   foreach (KeyValuePair<String, JToken> recipe in root)
                    {
                        if (recipe.Key.Equals("title"))
                        {
                            toadd += ((String)recipe.Value);
                            toadd += ",\tcalories: ";
                            name = ((String)recipe.Value);
                        }

                        else if (recipe.Key.Equals("calories"))
                        {
                            toadd += ((String)recipe.Value);
                            calories = ((String)recipe.Value);
                        }

                        else if (recipe.Key.Equals("protein"))
                        {
                            protein = ((String)recipe.Value);
                        }

                        else if (recipe.Key.Equals("fat"))
                        {
                            fat = ((String)recipe.Value);
                        }

                        else if (recipe.Key.Equals("carbs"))
                        {
                            carbs = ((String)recipe.Value);
                        }

                        else if (recipe.Key.Equals("image"))
                        {
                            imageurl = ((String)recipe.Value);
                        }
                    }
                    profileResultsBox.Items.Add(toadd);
                    currentRecipes.Add(toadd, imageurl);
                    macrosList = new string[] { calories, protein, fat, carbs };
                    carbs = carbs.TrimEnd('g');
                    protein = protein.TrimEnd('g');
                    fat = fat.TrimEnd('g');
                    //recipesToAdd.Add(name, macrosList);//This is where we add all the data we need to put in the databse into the dictionary
                    Utilities.SqlQueries.addMeal(name, Convert.ToInt32(calories), Convert.ToInt32(protein), Convert.ToInt32(fat), Convert.ToInt32(carbs));
                    imageurl = "";
                    toadd = "";
                }
            }
            response.Close();
        }

        protected void buttonUser_Click(object sender, EventArgs e)
        {
            if (Utilities.Helper.RegexUserCheck(textUser.Text) && Utilities.Helper.RegexUserCheck(textPass.Text))
            {

                List<string> profile = Utilities.SqlQueries.profilePopulate(textUser.Text);
                textUser.BackColor = System.Drawing.Color.White;
                textPass.BackColor = System.Drawing.Color.White;
                height.Text = profile[0] + " Inches";
                weight.Text = profile[1] + " Pounds";
                sex.Text = profile[2];
                age.Text = profile[3];
                calories.Text = profile[4];
            }
            else 
            {
                ErrorLabel.Text = "Username and Password do not meet minimum requirements.";
                textUser.BackColor = System.Drawing.Color.Red;
                textPass.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}