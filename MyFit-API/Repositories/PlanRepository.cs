using MyFit_API.Database;
using MyFit_Libs.Models;
using System.Data.SqlClient;

namespace MyFit_API.Repositories
{
    public class PlanRepository
    {

        internal List<Plan> GetAllPlans()
        {
            string query = "SELECT * FROM [Plan]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<Plan>>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal Plan GetPlanById(byte id)
        {
            string query = "SELECT * FROM [Plan] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<Plan>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetPlanName(byte id)
        {
            string query = "SELECT Nome FROM [Plan] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal byte? GetPlanValue(byte id)
        {
            string query = "SELECT Value FROM [Plan] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<byte?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal float? GetPlanPrice(byte id)
        {
            string query = "SELECT Price FROM [Plan] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<float?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetPlanDescription(byte id)
        {
            string query = "SELECT Description FROM [Plan] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void AddPlan(Plan plan)
        {
            string Name = plan.Name, Description = plan.Description;
            byte Value = plan.Value;
            float Price = plan.Price;

            string query = "INSERT INTO [Plan] ([Name],[Value],[Price],[Description]) VALUES (@_name,@_value,@_price,@_description)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_name", Name);
            cmd.Parameters.AddWithValue("@_value", Value);
            cmd.Parameters.AddWithValue("@_price", Price);
            cmd.Parameters.AddWithValue("@_description", Description);

            DatabaseManager<object>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal object? SetPlanName(byte id, string name)
        {
            string query = "UPDATE [Plan] SET Name = @_name WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_name", name);

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal object? SetPlanValue(byte id, byte value)
        {
            string query = "UPDATE [Plan] SET Value = @_value WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_value", value);

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal object? SetPlanPrice(byte id, float price)
        {
            string query = "UPDATE [Plan] SET Price = @_price WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_price", price);

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal object? SetPlanDescription(byte id, string description)
        {
            string query = "UPDATE [Plan] SET Description = @_description WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_description", description);

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal object? DeletePlanById(byte id)
        {
            string query = "DELETE FROM [Plan] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal long CountPlans()
        {
            string query = "SELECT COUNT(*) FROM [Plan]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<long>.GetInstance().MakeQueryOneScalarResult(cmd);
        }

        internal long CountHowManyPlansById(byte id)
        {
            string query = "SELECT COUNT(*) FROM [User] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<long>.GetInstance().MakeQueryOneScalarResult(cmd);
        }
    }
}
