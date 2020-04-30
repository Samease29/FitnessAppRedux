using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            int maxcals = Int32.Parse(caloriesText.Text);//this needs to be changed to whatever actually will parse an int, will change once page is updated
            int mincals = maxcals / 3;
            WebRequest request = WebRequest.Create("https://api.spoonacular.com/recipes/findByNutrients?minCalories=" + mincals + "&maxCalories=" + maxcals + "&number=10&apiKey=a1b8fa50293f4158a5a46e6fc461ae31");
            WebResponse response = request.GetResponse();
            using (Stream datastream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(datastream);// open the stream using a streamreader for easy access
                string responsefromserver = reader.ReadToEnd();// holds the string that is basically the json
                var parseddata = JArray.Parse(responsefromserver);//parses it into a jarray, basically something for us to loop through to get the data out of

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
                        }

                        else if (recipe.Key.Equals("calories"))
                        {
                            toadd += ((String)recipe.Value);
                        }

                        else if (recipe.Key.Equals("image"))
                        {
                            imageurl = ((String)recipe.Value);
                        }
                    }
                    profileResultsBox.Items.Add(toadd);
                    currentRecipes.Add(toadd, imageurl);
                    imageurl = "";
                    toadd = "";
                }
            }
            response.Close();
        }
    }
}