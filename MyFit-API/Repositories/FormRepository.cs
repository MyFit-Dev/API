using MyFit_API.Database;
using MyFit_Libs.Models;
using System.Data.SqlClient;

namespace MyFit_API.Repositories
{
    public class FormRepository
    {

        internal List<Form>? GetAllForms()
        {
            string query = "SELECT * FROM [Form]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<Form>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal bool ExistsForm(long id)
        {
            string query = "SELECT COUNT(Id) FROM [Form] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<int>.GetInstance().MakeQueryOneScalarResult(cmd) > 0;
        }

        internal Form? GetForm(long id)
        {
            string query = "SELECT * FROM [Form] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);  

            return DatabaseManager<Form?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal List<Form>? GetUserForms(long idUser)
        {
            string query = "SELECT * FROM [Form] WHERE IdUser = @_idUser";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", idUser);

            return DatabaseManager<List<Form>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal string? GetGenericExercisesOfForm(long id)
        {
            string query = "SELECT GenericExercises FROM [Form] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetCustomExercisesOfForm(long id)
        {
            string query = "SELECT CustomExercises FROM [Form] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void AddForm(Form? form)
        {
            long IdUser = form.IdUser;
            string GenericExercises = form.GenericExercises, CustomExercises = form.CustomExercises;

            string query = "INSERT INTO [Form] ([IdUser],[GenericExerercises],[CustomExercises]) VALUES (@_idUser,@_genericExercise,@_customExercise)";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", IdUser);
            cmd.Parameters.AddWithValue("@_genericExercise", GenericExercises);
            cmd.Parameters.AddWithValue("@_customExercise", CustomExercises);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetFormGenericExercises(long id, string? genericExercises)
        {
            string query = "UPDATE [Form] SET GenericExercises = @_genericExercises WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_genericExercise", genericExercises);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetFormCustomExercises(long id, string? customExercises)
        {
            string query = "UPDATE [Form] SET CustomExercises = @_customExercises WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_customExercise", customExercises);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteForm(long id)
        {
            string query = "DELETE FROM [Form] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteUserForms(long idUser)
        {
            string query = "DELETE FROM [Form] WHERE IdUser = @_idUser";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", idUser);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal int CountUserForms(long idUser)
        {
            string query = "SELECT COUNT(Id) FROM [Form] WHERE IdUser = @_idUser";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", idUser);

            return DatabaseManager<int>.GetInstance().MakeQueryOneScalarResult(cmd);
        }

        internal long CountForms()
        {
            string query = "SELECT COUNT(Id) FROM [Form]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<long>.GetInstance().MakeQueryOneScalarResult(cmd);
        }

    }
}
