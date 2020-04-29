using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace FitnessAppRedux.Utilities
{
    public class SqlQueries
    {
        static string connString = ConfigurationManager.ConnectionStrings["FitnessApp"].ConnectionString;

        public static void createUser(string username, string password, int height, int weight, string sex, int age, int tdee)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
              
                    using(SqlCommand createUserCmd = new SqlCommand("INSERT INTO [User] (Username, Password, Height, Weight, Sex, Age, Tdee) VALUES (@Username, @Password, @Height, @Weight, @Sex, @Age, @Tdee)", conn))
                    {
                        createUserCmd.Parameters.Add("@Username", SqlDbType.VarChar, 50);
                        createUserCmd.Parameters.Add("@Password", SqlDbType.VarChar, 20);
                        createUserCmd.Parameters.Add("@Height", SqlDbType.Int);
                        createUserCmd.Parameters.Add("@Weight", SqlDbType.Int);
                        createUserCmd.Parameters.Add("@Sex", SqlDbType.VarChar, 1);
                        createUserCmd.Parameters.Add("@Age", SqlDbType.Int);
                        createUserCmd.Parameters.Add("@Tdee", SqlDbType.Int);
                        createUserCmd.Parameters["@Username"].Value = username;
                        createUserCmd.Parameters["@Password"].Value = password;
                        createUserCmd.Parameters["@Height"].Value = height;
                        createUserCmd.Parameters["@Weight"].Value = weight;
                        createUserCmd.Parameters["@Sex"].Value = sex;
                        createUserCmd.Parameters["@Age"].Value = age;
                        createUserCmd.Parameters["@Tdee"].Value = tdee;
                        conn.Open();

                        int result = createUserCmd.ExecuteNonQuery();
                        if(result < 0)
                        {
                            System.Diagnostics.Debug.WriteLine("Error creating new user");
                        }
                        else
                        {
                            System.Diagnostics.Debug.WriteLine("User Created");
                        }
                    }
                }
            }
            catch(SqlException e)
            {
                StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < e.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + e.Errors[i].Message + "\n" +
                        "LineNumber: " + e.Errors[i].LineNumber + "\n" +
                        "Source: " + e.Errors[i].Source + "\n" +
                        "Procedure: " + e.Errors[i].Procedure + "\n");
                }
                System.Diagnostics.Debug.Write(errorMessages.ToString());
            }
        }

        public static int loginUser(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand loginCmd = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE Username = @Username AND Password = @Password", conn))
                    {
                        conn.Open();
                        loginCmd.Parameters.Add("@Username", SqlDbType.VarChar, 50);
                        loginCmd.Parameters.Add("@Password", SqlDbType.VarChar, 20);
                        loginCmd.Parameters["@Username"].Value = username;
                        loginCmd.Parameters["@Password"].Value = password;

                        int result = Convert.ToInt32(loginCmd.ExecuteScalar());
                        if(result == 1)
                        {
                            return result;
                        }
                        else
                        {
                            return result;
                        }
                    }
                }
            }
            catch(SqlException e)
            {
                StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < e.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + e.Errors[i].Message + "\n" +
                        "LineNumber: " + e.Errors[i].LineNumber + "\n" +
                        "Source: " + e.Errors[i].Source + "\n" +
                        "Procedure: " + e.Errors[i].Procedure + "\n");
                }
                System.Diagnostics.Debug.Write(errorMessages.ToString());
                return 0;
            }
        }

        public static List<string> profilePopulate(string username)
        {
            SqlDataReader dr;
            List<string> result = new List<string>();
            string[] results = { "Height", "Weight", "Sex", "Age", "Tdee" };
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using(SqlCommand profileCmd = new SqlCommand("SELECT Height, Weight, Sex, Age, Tdee  FROM [User] WHERE Username = @UserName", conn))
                    {
                        profileCmd.Parameters.Add("@Username", SqlDbType.VarChar, 50);
                        profileCmd.Parameters["@Username"].Value = username;
                        conn.Open();

                        dr = profileCmd.ExecuteReader();
                        while (dr.Read())
                        {
                            foreach(string entry in results)
                            {
                                result.Add(Convert.ToString(dr[entry]));
                            }
                        }
                    }
                }
                return result;
            }
            catch(SqlException e)
            {
                //do nothing
                return null;
            }
        }

        public static void addMeal(string meal, int calories, int protein, int carbs, int fat)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using(SqlCommand profileCmd = new SqlCommand("INSERT INTO Meal (Name, Calories, Protein, Carbs, Fat) VALUES (@Name, @Calories, @Protein, @Carbs, @Fat)", conn))
                    {
                        profileCmd.Parameters.Add("@Name", SqlDbType.VarChar, 50);
                        profileCmd.Parameters.Add("@Calories", SqlDbType.Int);
                        profileCmd.Parameters.Add("@Protein", SqlDbType.Int);
                        profileCmd.Parameters.Add("@Carbs", SqlDbType.Int);
                        profileCmd.Parameters.Add("@Fat", SqlDbType.Int);
                        profileCmd.Parameters["@Name"].Value = meal;
                        profileCmd.Parameters["@Calories"].Value = calories;
                        profileCmd.Parameters["@Protein"].Value = protein;
                        profileCmd.Parameters["@Carbs"].Value = carbs;
                        profileCmd.Parameters["@Fat"].Value = fat;

                        int result = profileCmd.ExecuteNonQuery();
                        if(result < 0)
                        {
                            System.Diagnostics.Debug.WriteLine("Error adding meal");
                        }
                        else
                        {
                            System.Diagnostics.Debug.WriteLine("Meal added");
                        }
                    }
                }
            }
            catch(SqlException e)
            {
                //do nothing
            }
        }
    }
}