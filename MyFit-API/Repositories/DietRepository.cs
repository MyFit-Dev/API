using MyFit_API.Database;
using MyFit_Libs.Models;
using MyFit_Libs.Utils;
using Newtonsoft.Json;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyFit_API.Repositories
{
    public class DietRepository
    {

        internal List<Diet>? GetAllDiets() 
        {
            string query = "SELECT * FROM [Diet]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<Diet>>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal bool ExistsDietById(long id)
        {
            string query = "SELECT COUNT(Id) FROM [Diet] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<int>.GetInstance().MakeQueryOneScalarResult(cmd) > 0;
        }

        internal bool ExistsDietByUserAndDate(long idUser, DateTime date)
        {
            string query = "SELECT COUNT(Id) FROM [Diet] WHERE IdUser = @_idUser AND Date = @_date";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", idUser);
            cmd.Parameters.AddWithValue("@_date", date.ToString("yyyy-MM-dd"));

            return DatabaseManager<int>.GetInstance().MakeQueryOneScalarResult(cmd) > 0;
        }

        internal List<Diet>? GetAllUserDiets(long idUser) 
        {
            string query = "SELECT * FROM [Diet] WHERE IdUser = @_id";
            SqlCommand cmd = new SqlCommand(query);
            
            cmd.Parameters.AddWithValue("@_id", idUser);

            return DatabaseManager<List<Diet>>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal Diet? GetUserDietByDate(long idUser, DateTime date)
        {
            string query = "SELECT * FROM [Diet] WHERE IdUser = @_idUser AND Date = @_date";
            SqlCommand cmd = new SqlCommand(query);
            
            cmd.Parameters.AddWithValue("@_idUser", idUser);
            cmd.Parameters.AddWithValue("@_date", date.ToString("yyyy-MM-dd"));

            return DatabaseManager<Diet?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal Diet? GetDiet(long id) 
        {
            string query = "SELECT * FROM [Diet] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<Diet>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetFoodList(long id)
        {
            string query = "SELECT FoodList FROM [Diet] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal List<string?>? GetAllUserFoodLists(long idUser)
        {
            string query = "SELECT FoodList FROM [Diet] WHERE IdUser = @_idUser";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", idUser);

            return DatabaseManager<List<string?>>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal string? GetUserFoodListByDate(long idUser, DateTime date)
        {
            string query = "SELECT FoodList FROM [Diet] WHERE IdUser = @_idUser AND Date = @_date";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", idUser);
            cmd.Parameters.AddWithValue("@_date", date.ToString("yyyy-MM-dd"));

            return DatabaseManager<string?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal List<string?>? GetUserFoodListBetweenDates(long idUser, DateTime startDate, DateTime endDate)
        {
            string query = "SELECT FoodList FROM [Diet] WHERE IdUser = @_idUser AND Date BETWEEN (@_startDate AND @_endDate)";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", idUser);
            cmd.Parameters.AddWithValue("@_startDate", startDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@_endDate", startDate.ToString("yyyy-MM-dd"));

            return DatabaseManager<List<string?>>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal void AddDiet(Diet diet)
        {
            long idUser = diet.IdUser;
            DateTime date = diet.Date;
            Dictionary<string, List<Meal>> foodList = diet.FoodList;

            string query = "INSERT INTO [Diet] ([IdUser],[FoodList],[Date]) VALUES (@_idUser,@_foodList,@_date)";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", idUser);
            cmd.Parameters.AddWithValue("@_date", date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@_foodList", JsonConvert.SerializeObject(foodList));

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal object? SetFoodListOfUser(long idUser, DateTime date, Dictionary<string, List<Meal>> foodList)
        {
            string query = "UPDATE [Diet] SET [FoodList] = @_foodList WHERE IdUser = @_idUser AND Date = @_date";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", idUser);
            cmd.Parameters.AddWithValue("@_date", date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@_foodList", JsonConvert.SerializeObject(foodList));

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal object? DeleteDiet(long id)
        {
            string query = "DELETE FROM [Diet] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal object? DeleteDietOfUserAndDate(long idUser, DateTime date)
        {
            string query = "DELETE FROM [Diet] WHERE IdUser = @_idUser AND Date = @_date";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", idUser);
            cmd.Parameters.AddWithValue("@_date", date.ToString("yyyy-MM-dd"));

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal object? DeleteDietsOfUser(long idUser)
        {
            string query = "DELETE FROM [Diet] WHERE IdUser = @_idUser";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", idUser);

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal object? DeleteDietsOfUserBetweenDate(long idUser, DateTime startDate, DateTime endDate)
        {
            string query = "DELETE FROM [Diet] WHERE IdUser = @_idUser AND Date BETWEEN (@_startDate AND @_endDate)";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", idUser);
            cmd.Parameters.AddWithValue("@_startDate", startDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@_endDate", endDate.ToString("yyyy-MM-dd"));

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

    }
}
