using MyFit_API.Database;
using MyFit_Libs.Models;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MyFit_API.Repositories
{
    public class CustomExerciseRepository
    {

        internal List<CustomExercise>? GetAllCustomExercises()
        {
            string query = "SELECT * FROM [CustomExercise]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<CustomExercise>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal CustomExercise? GetCustomExercise(long id)
        {
            string query = "SELECT * FROM [CustomExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<CustomExercise?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal List<CustomExercise>? GetUserCustomExercises(long idUser)
        {
            string query = "SELECT * FROM [CustomExercise] WHERE IdUser = @_idUser";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", idUser);

            return DatabaseManager<List<CustomExercise>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal bool ExistsCustomExercise(long id)
        {
            string query = "SELECT COUNT(Id) FROM [CustomExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<int>.GetInstance().MakeQueryOneScalarResult(cmd) > 0;
        }

        internal string? GetCustomExerciseName(long id)
        {
            string query = "SELECT Name FROM [CustomExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetCustomExerciseDescription(long id)
        {
            string query = "SELECT Description FROM [CustomExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetCustomExerciseMethod(long id)
        {
            string query = "SELECT Method FROM [CustomExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetCustomExerciseImage(long id)
        {
            string query = "SELECT Image FROM [CustomExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetCustomExerciseVideo(long id)
        {
            string query = "SELECT Video FROM [CustomExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal int? GetCustomExerciseDuration(long id)
        {
            string query = "SELECT Duration FROM [CustomExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<int?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal byte? GetCustomExerciseDifficulty(long id)
        {
            string query = "SELECT Difficulty FROM [CustomExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<byte?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal int? GetCustomExerciseCalories(long id)
        {
            string query = "SELECT Calories FROM [CustomExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<int?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetCustomExerciseTarget(long id)
        {
            string query = "SELECT Target FROM [CustomExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal bool? GetCustomExercisePrivate(long id)
        {
            string query = "SELECT Private FROM [CustomExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<bool?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void AddCustomExercise(CustomExercise customExercise)
        {
            string Name = customExercise.Name, Description = customExercise.Description, Method = customExercise.Method, Image = customExercise.Image, Video = customExercise.Video, Target = customExercise.Target;
            long IdUser = customExercise.IdUser;
            bool Private = customExercise.Private;
            int Calories = customExercise.Calories, Duration = customExercise.Duration;
            byte Difficulty = customExercise.Difficulty;

            string query = "INSERT INTO [CustomExercise] ([IdUser],[Name],[Description],[Method],[Image],[Video],[Duration],[Difficulty],[Calories],[Private])" +
                "VALUES (@_idUser,@_name,@_description,@_method,@_image,@_video,@_duration,@_difficulty,@_calories,@_private))";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", IdUser);
            cmd.Parameters.AddWithValue("@_name", Name);
            cmd.Parameters.AddWithValue("@_description", Description);
            cmd.Parameters.AddWithValue("@_method", Method);
            cmd.Parameters.AddWithValue("@_image", Image);
            cmd.Parameters.AddWithValue("@_video", Video);
            cmd.Parameters.AddWithValue("@_duration", Duration);
            cmd.Parameters.AddWithValue("@_difficulty", Difficulty);
            cmd.Parameters.AddWithValue("@_calories", Calories);
            cmd.Parameters.AddWithValue("@_private", Private);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetCustomExerciseName(long id, string name)
        {
            string query = "UPDATE [CustomExercise] SET Name = @_name WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_name", name);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetCustomExerciseDescription(long id, string description)
        {
            string query = "UPDATE [CustomExercise] SET Description = @_description WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_description", description);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetCustomExerciseMethod(long id, string method)
        {
            string query = "UPDATE [CustomExercise] SET Method = @_method WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_method", method);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetCustomExerciseImage(long id, string image)
        {
            string query = "UPDATE [CustomExercise] SET Image = @_image WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_image", image);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetCustomExerciseVideo(long id, string video)
        {
            string query = "UPDATE [CustomExercise] SET Video = @_video WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_video", video);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetCustomExerciseDuration(long id, int duration)
        {
            string query = "UPDATE [CustomExercise] SET Duration = @_duration WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_duration", duration);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetCustomExerciseCalories(long id, int calories)
        {
            string query = "UPDATE [CustomExercise] SET Calories = @_calories WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_calories", calories);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetCustomExerciseDifficulty(long id, byte difficulty)
        {
            string query = "UPDATE [CustomExercise] SET Difficulty = @_difficulty WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_difficulty", difficulty);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetCustomExerciseTarget(long id, string target)
        {
            string query = "UPDATE [CustomExercise] SET Target = @_target WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_target", target);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetCustomExercisePrivate(long id, bool privato)
        {
            string query = "UPDATE [CustomExercise] SET Private = @_private WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_private", privato);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteCustomExercise(long id)
        {
            string query = "DELETE FROM [CustomExercise] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteUserCustomExercises(long idUser)
        {
            string query = "DELETE FROM [CustomExercise] WHERE IdUser = @_idUser";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", idUser);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal int CountUserCustomExercises(long id)
        {
            string query = "SELECT COUNT(Id) FROM [CustomExercise] WHERE IdUser = @_idUser";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", id);

            return DatabaseManager<int>.GetInstance().MakeQueryOneScalarResult(cmd);
        }


    }
}
