using MyFit_API.Database;
using MyFit_Libs.Models;
using System.Data.SqlClient;

namespace MyFit_API.Repositories
{
    public class RecordRepository
    {

        internal List<Record>? GetAllRecords()
        {
            string query = "SELECT * FROM [Record]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<Record>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal Record? GetRecord(int id)
        {
            string query = "SELECT * FROM [Record] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<Record?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal bool ExistsRecord(int id)
        {
            string query = "SELECT COUNT(Id) FROM [Record] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<int>.GetInstance().MakeQueryOneScalarResult(cmd) > 0;
        }

        internal string? GetRecordName(int id)
        {
            string query = "SELECT Name FROM [Record] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetRecordGoal(int id)
        {
            string query = "SELECT Goal FROM [Record] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetRecordReward(int id)
        {
            string query = "SELECT Reward FROM [Record] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal int GetRecordDifficulty(int id)
        {
            string query = "SELECT Difficulty FROM [Record] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<int>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void AddRecord(Record record)
        {
            string Name = record.Name, Goal = record.Goal;
            string? Reward = record.Reward;
            int? Difficulty = record.Difficulty;

            string query = "INSERT INTO [Record] ([Name],[Goal],[Reward],[Difficulty]) VALUES (@_name,@_goal,@_reward,@_difficulty)";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_name", Name);
            cmd.Parameters.AddWithValue("@_goal", Goal);
            cmd.Parameters.AddWithValue("@_reward", Reward);
            cmd.Parameters.AddWithValue("@_difficulty", Difficulty);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetRecordName(int id, string name)
        {
            string query = "UPDATE [Record] SET Name = @_name WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_name", name);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetRecordGoal(int id, string goal)
        {
            string query = "UPDATE [Record] SET Goal = @_goal WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_goal", goal);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetRecordReward(int id, string? reward)
        {
            string query = "UPDATE [Record] SET Reward = @_reward WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_reward", reward);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetRecordDifficulty(int id, int difficulty)
        {
            string query = "UPDATE [Record] SET Difficulty = @_difficulty WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_difficulty", difficulty);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteRecord(int id)
        {
            string query = "DELETE FROM [Record] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

    }
}
