using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json.Linq;

namespace FitnessAppRedux
{
    public partial class RecipeRequest : System.Web.UI.Page
    {
        static Dictionary<String, String> currentRecipes = new Dictionary<String, String>();//To hold the Strings to display in the list box and the image urls associated

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String minCals = TextBox2.Text;
            String maxCals = TextBox1.Text;
            WebRequest request = WebRequest.Create("https://api.spoonacular.com/recipes/findByNutrients?minCalories=" + minCals + "&maxCalories=" + maxCals + "&number=10&apiKey=a1b8fa50293f4158a5a46e6fc461ae31");
            WebResponse response = request.GetResponse();
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);// Open the stream using a StreamReader for easy access
                string responseFromServer = reader.ReadToEnd();// Holds the String that is basically the JSON
                var parsedData = JArray.Parse(responseFromServer);//Parses it into a JArray, basically something for us to loop through to get the data out of

                resultsBox.Items.Clear();//Clear the resultsBox in case someone already made a request and is making another
                String toAdd = "";//Using this string to build results entries. Append on titles and calories
                String imageURL = "";
                currentRecipes.Clear();
                foreach(JObject root in parsedData)//loop to pull out the title and calories for each returned recipe
                {
                    foreach(KeyValuePair<String, JToken> recipe in root)
                    {
                        if(recipe.Key.Equals("title"))
                        {
                            toAdd += ((String)recipe.Value);
                            toAdd += ",\tCalories: ";
                        }
                        
                        else if(recipe.Key.Equals("calories"))
                        {
                            toAdd += ((String)recipe.Value);
                        }

                        else if(recipe.Key.Equals("image"))
                        {
                            imageURL = ((String)recipe.Value);
                        }
                    }
                    resultsBox.Items.Add(toAdd);
                    currentRecipes.Add(toAdd, imageURL);
                    imageURL = "";
                    toAdd = "";
                }
            }
            response.Close();
        }

        protected void resultsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foodImage.ImageUrl = currentRecipes[resultsBox.SelectedValue];
        }
    }
}