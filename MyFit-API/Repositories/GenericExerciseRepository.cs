using MyFit_API.Database;
using MyFit_Libs.Models;
using System.Data.SqlClient;

namespace MyFit_API.Repositories
{
    public class GenericExerciseRepository
    {

        internal List<GenericExercise>? GetAllGenericExercises()
        {
            string query = "SELECT * FROM [GenericExercise]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<GenericExercise>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal GenericExercise? GetGenericExercise(long id)
        {
            string query = "SELECT * FROM [GenericExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<GenericExercise?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetGenericExerciseName(long id)
        {
            string query = "SELECT Name FROM [GenericExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal bool ExistsGenericExercise(long id)
        {
            string query = "SELECT COUNT(Id) FROM [GenericExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<int>.GetInstance().MakeQueryOneScalarResult(cmd) > 0;
        }

        internal string? GetGenericExerciseDescription(long id)
        {
            string query = "SELECT Description FROM [GenericExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetGenericExerciseMethod(long id)
        {
            string query = "SELECT Method FROM [GenericExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetGenericExerciseImage(long id)
        {
            string query = "SELECT Image FROM [GenericExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetGenericExerciseVideo(long id)
        {
            string query = "SELECT Video FROM [GenericExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal int? GetGenericExerciseDuration(long id)
        {
            string query = "SELECT Duration FROM [GenericExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<int?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal byte? GetGenericExerciseDifficulty(long id)
        {
            string query = "SELECT Difficulty FROM [GenericExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<byte?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal int? GetGenericExerciseCalories(long id)
        {
            string query = "SELECT Calories FROM [GenericExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<int?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetGenericExerciseTarget(long id)
        {
            string query = "SELECT Target FROM [GenericExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void AddGenericExercise(GenericExercise GenericExercise)
        {
            string Name = GenericExercise.Name, Description = GenericExercise.Description, Method = GenericExercise.Method, Image = GenericExercise.Image, Video = GenericExercise.Video, Target = GenericExercise.Target;
            int Calories = GenericExercise.Calories, Duration = GenericExercise.Duration;
            byte Difficulty = GenericExercise.Difficulty;

            string query = "INSERT INTO [GenericExercise] ([Name],[Description],[Method],[Image],[Video],[Duration],[Difficulty],[Calories])" +
                "VALUES (@_name,@_description,@_method,@_image,@_video,@_duration,@_difficulty,@_calories))";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_name", Name);
            cmd.Parameters.AddWithValue("@_description", Description);
            cmd.Parameters.AddWithValue("@_method", Method);
            cmd.Parameters.AddWithValue("@_image", Image);
            cmd.Parameters.AddWithValue("@_video", Video);
            cmd.Parameters.AddWithValue("@_duration", Duration);
            cmd.Parameters.AddWithValue("@_difficulty", Difficulty);
            cmd.Parameters.AddWithValue("@_calories", Calories);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetGenericExerciseName(long id, string name)
        {
            string query = "UPDATE [GenericExercise] SET Name = @_name WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_name", name);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetGenericExerciseDescription(long id, string description)
        {
            string query = "UPDATE [GenericExercise] SET Description = @_description WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_description", description);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetGenericExerciseMethod(long id, string method)
        {
            string query = "UPDATE [GenericExercise] SET Method = @_method WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_method", method);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetGenericExerciseImage(long id, string image)
        {
            string query = "UPDATE [GenericExercise] SET Image = @_image WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_image", image);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetGenericExerciseVideo(long id, string video)
        {
            string query = "UPDATE [GenericExercise] SET Video = @_video WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_video", video);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetGenericExerciseDuration(long id, int duration)
        {
            string query = "UPDATE [GenericExercise] SET Duration = @_duration WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_duration", duration);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetGenericExerciseCalories(long id, int calories)
        {
            string query = "UPDATE [GenericExercise] SET Calories = @_calories WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_calories", calories);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetGenericExerciseDifficulty(long id, byte difficulty)
        {
            string query = "UPDATE [GenericExercise] SET Difficulty = @_difficulty WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_difficulty", difficulty);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetGenericExerciseTarget(long id, string target)
        {
            string query = "UPDATE [GenericExercise] SET Target = @_target WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_target", target);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteGenericExercise(long id)
        {
            string query = "DELETE FROM [GenericExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

    }
}
