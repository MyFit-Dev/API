using MyFit_API.Database;
using MyFit_Libs.Models;
using System.Data.SqlClient;

namespace MyFit_API.Repositories
{
    public class PlanRepository
    {

        internal List<Plan>? GetAllPlans()
        {
            string query = "SELECT * FROM [Plan]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<Plan>>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal Plan? GetPlanById(byte id)
        {
            string query = "SELECT * FROM [Plan] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<Plan>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void AddPlan(Plan plan)
        {
            string Name = plan.Name, Description = plan.Description, Subtitle = plan.Subtitle, Color = plan.Color; 
            byte Value = plan.Value;
            float Price = plan.Price;

            string query = "INSERT INTO [Plan] ([Name],[Subtitle],[Color][Value],[Price],[Description]) VALUES (@_name,@_subtitle,@_color@_value,@_price,@_description)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_name", Name);
            cmd.Parameters.AddWithValue("@_subtitle", Subtitle);
            cmd.Parameters.AddWithValue("@_color", Color);
            cmd.Parameters.AddWithValue("@_value", Value);
            cmd.Parameters.AddWithValue("@_price", Price);
            cmd.Parameters.AddWithValue("@_description", Description);

            DatabaseManager<object>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetPlanName(byte id, string name)
        {
            string query = "UPDATE [Plan] SET Name = @_name WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_name", name);

            DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void SetPlanSubtitle(byte id, string subtitle)
        {
            string query = "UPDATE [Plan] SET Subtitle = @_subtitle WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_subtitle", subtitle);

            DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void SetPlanColor(byte id, string color)
        {
            string query = "UPDATE [Plan] SET Color = @_color WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_color", color);

            DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void SetPlanValue(byte id, byte value)
        {
            string query = "UPDATE [Plan] SET Value = @_value WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_value", value);

            DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void SetPlanPrice(byte id, float price)
        {
            string query = "UPDATE [Plan] SET Price = @_price WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_price", price);

            DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void SetPlanDescription(byte id, string description)
        {
            string query = "UPDATE [Plan] SET Description = @_description WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_description", description);

            DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void DeletePlanById(byte id)
        {
            string query = "DELETE FROM [Plan] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal int CountPlans()
        {
            string query = "SELECT COUNT(*) FROM [Plan]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<int>.GetInstance().MakeQueryOneScalarResult(cmd);
        }

        internal long CountHowManyPlansById(byte id)
        {
            string query = "SELECT COUNT(*) FROM [User] WHERE IdPlan = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<long>.GetInstance().MakeQueryOneScalarResult(cmd);
        }
    }
}
