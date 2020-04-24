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
    public partial class RecipeRequest : System.Web.UI.Page
    {
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
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer);
            }
            response.Close();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}