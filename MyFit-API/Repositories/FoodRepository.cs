using MyFit_API.Database;
using MyFit_Libs.Models;
using System.Data.SqlClient;

namespace MyFit_API.Repositories
{
    public class FoodRepository
    {

        internal List<Food>? GetAllFoods()
        {
            string query = "SELECT * FROM [Food]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<Food>>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal List<Food>? GetSimilarFoods(string name, int results)
        {
            string query = results > 0 ? "SELECT TOP @_results * FROM [Food] WHERE Name LIKE %@_name%" : "SELECT * FROM [Food] WHERE Name LIKE %@_name%";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_results", results);
            cmd.Parameters.AddWithValue("@_name", name);

            return DatabaseManager<List<Food>>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal long CountFoods()
        {
            string query = "SELECT COUNT(Id) FROM [Food]";
            SqlCommand cmd = new SqlCommand(query);
            
            return DatabaseManager<long>.GetInstance().MakeQueryOneScalarResult(cmd);
        }

        internal bool ExistsFood(long id)
        {
            string query = "SELECT COUNT(Id) FROM [Food] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<int>.GetInstance().MakeQueryOneScalarResult(cmd) > 0;
        }

        internal Food? GetFood(long id)
        {
            string query = "SELECT * FROM [Food] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<Food>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void AddFood(Food food)
        {
            string Name = food.Name;
            string? Description = food.Description, Image = food.Image;
            int Weight = food.Weight, Calories = food.Calories;
            byte Proteins = food.Proteins, Carbs = food.Carbs, Sugars = food.Sugars, Fats = food.Fats, Salt = food.Salt;
            byte? Saturated_Fats = food.Saturated_Fats, Polyunsaturated_Fats = food.Polyunsaturated_Fats, Monounsaturated_Fats = food.Monounsaturated_Fats, Trans_Fats = food.Trans_Fats,
                Cholesterol = food.Cholesterol, Magnesium = food.Magnesium, Potassium = food.Potassium, Iron = food.Iron, Calcium = food.Calcium, Vitamin_A = food.Vitamin_A,
                Vitamin_B1 = food.Vitamin_B1, Vitamin_B2 = food.Vitamin_B2, Vitamin_B6 = food.Vitamin_B6, Vitamin_B12 = food.Vitamin_B12, Vitamin_C = food.Vitamin_C,
                Vitamin_D = food.Vitamin_D, Vitamin_E = food.Vitamin_E;

            string query = "INSERT INTO [Food] ([Name],[Description],[Weight],[Calories],[Proteins],[Carbs],[Sugars],[Fats],[Salt],[Saturated_Fats],[Polyunsaturated_Fats],[Monounsaturated_Fats]," +
                "[Trans_Fats],[Cholesterol],[Magnesium],[Potassium],[Iron],[Calcium],[Vitamin_A],[Vitamin_B1],[Vitamin_B2],[Vitamin_B6],[Vitamin_B12],[Vitamin_C],[Vitamin_D],[Vitamin_E],[Image]) VALUES (" +
                "@_name,@_description,@_weight,@_calories,@_proteins,@_carbs,@_sugars,@_fats,@_salt,@_saturatedFats,@_polyunsaturatedFats,@_monounsaturatedFats,@_transFats,@_cholesterol,@_magnesium," +
                "@_potassium,@_iron,@_calcium,@_vitaminA,@_vitaminB1,@_vitaminB2,@_vitaminB6,@_vitaminB12,@_vitaminC,@_vitaminD,@_vitaminE,@_image)";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_name", Name);
            cmd.Parameters.AddWithValue("@_description", Description);
            cmd.Parameters.AddWithValue("@_weight", Weight);
            cmd.Parameters.AddWithValue("@_calories", Calories);
            cmd.Parameters.AddWithValue("@_proteins", Proteins);
            cmd.Parameters.AddWithValue("@_carbs", Carbs);
            cmd.Parameters.AddWithValue("@_sugars", Sugars);
            cmd.Parameters.AddWithValue("@_fats", Fats);
            cmd.Parameters.AddWithValue("@_salt", Salt);
            cmd.Parameters.AddWithValue("@_saturatedFats", Saturated_Fats);
            cmd.Parameters.AddWithValue("@_polyunsaturatedFats", Polyunsaturated_Fats);
            cmd.Parameters.AddWithValue("@_monounsaturatedFats", Monounsaturated_Fats);
            cmd.Parameters.AddWithValue("@_transFats", Trans_Fats);
            cmd.Parameters.AddWithValue("@_cholesterol", Cholesterol);
            cmd.Parameters.AddWithValue("@_magnesium", Magnesium);
            cmd.Parameters.AddWithValue("@_potassium", Potassium);
            cmd.Parameters.AddWithValue("@_iron", Iron);
            cmd.Parameters.AddWithValue("@_calcium", Calcium);
            cmd.Parameters.AddWithValue("@_vitaminA", Vitamin_A);
            cmd.Parameters.AddWithValue("@_vitaminB1", Vitamin_B1);
            cmd.Parameters.AddWithValue("@_vitaminB2", Vitamin_B2);
            cmd.Parameters.AddWithValue("@_vitaminB6", Vitamin_B6);
            cmd.Parameters.AddWithValue("@_vitaminB12", Vitamin_B12);
            cmd.Parameters.AddWithValue("@_vitaminC", Vitamin_C);
            cmd.Parameters.AddWithValue("@_vitaminD", Vitamin_D);
            cmd.Parameters.AddWithValue("@_vitaminE", Vitamin_E);
            cmd.Parameters.AddWithValue("@_image", Image);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteFood(long id)
        {
            string query = "DELETE FROM [Food] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
        }
    }
}
