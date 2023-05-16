using MyFit_API.Database;
using MyFit_Libs.Models;
using System.Data.SqlClient;

namespace MyFit_API.Repositories
{
    public class UserRepository
    {
        internal List<User> GetAllUsers()
        {
            string query = "SELECT * FROM [User]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<User>>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal User? GetUserById(long id)
        {
            string query = "SELECT * FROM [User] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);
            return DatabaseManager<User>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal User? GetUserByMail(string mail)
        {
            string query = "SELECT * FROM [User] WHERE Mail = @_mail";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_mail", mail);
            return DatabaseManager<User>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal Plan? GetUserPlan(long id)
        {
            string query = "SELECT p.Id, p.Name, p.Value, p.Price, p.Description FROM [User] u JOIN [Plan] p ON p.Id = u.IdPlan WHERE u.Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);
            return DatabaseManager<Plan>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal Gym? GetUserGym(long id)
        {
            string query = "SELECT g.Id, g.Name, g.IdStaff, g.State, g.City, g.Street, g.CivicNumber, g.CAP FROM [User] u JOIN [Gym] ON g.Id = u.IdGym WHERE u.Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);
            return DatabaseManager<Gym>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetUserFoodListOnDate(long id, DateTime date) 
        {
            string query = "SELECT d.FoodList FROM [User] u JOIN [Diet] d ON u.Id = d.IdUser WHERE u.Id = @_id AND d.Date = @_date";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_date", date);
            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal bool IsUserOnIntermittentFasting(long id)
        {
            string query = "SELECT IntermittentFasting FROM [User] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);
            return DatabaseManager<bool>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void AddUser(User user)
        {
            string Name = user.Name, Surname = user.Surname, Mail = user.Mail, State = user.State,
                City = user.City;
            int IdPlan = user.IdPlan;
            int? IdGym = user.IdGym;
            bool IntermittentFasting = user.IntermittentFasting;

            string query = "INSERT INTO [User] ([Name],[Surname],[Mail],[State],[City],[IdPlan],[IdGym],[IntermittentFasting]) VALUES (@_name, @_surname, @_mail, @_state, @_city, @_idPlan, @_idGym, @_intermittentFasting)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_name", Name);
            cmd.Parameters.AddWithValue("@_surname", Surname);
            cmd.Parameters.AddWithValue("@_mail", Mail);
            cmd.Parameters.AddWithValue("@_state", State);
            cmd.Parameters.AddWithValue("@_city", City);
            cmd.Parameters.AddWithValue("@_idPlan", IdPlan);
            cmd.Parameters.AddWithValue("@_idGym", IdGym);
            cmd.Parameters.AddWithValue("@_intermittentFasting", IntermittentFasting);

            DatabaseManager<object>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal object? SetUserName(long id, string name)
        {
            string query = "UPDATE [User] SET Name = @_name WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_name", name);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal object? SetUserSurname(long id, string surname)
        {
            string query = "UPDATE [User] SET Surname = @_surname WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_surname", surname);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal object? SetUserMail(long id, string mail)
        {
            string query = "UPDATE [User] SET Mail = @_mail WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_mail", mail);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal object? SetUserState(long id, string state)
        {
            string query = "UPDATE [User] SET State = @_state WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_state", state);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal object? SetUserCity(long id, string city)
        {
            string query = "UPDATE [User] SET City = @_city WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_city", city);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal object? SetUserPlan(long id, int? idPlan)
        {
            string query = "UPDATE [User] SET IdPlan = @_idPlan WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_idPlan", idPlan);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal object? SetUserGym(long id, int? idGym)
        {
            string query = "UPDATE [User] SET IdGym = @_idGym WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_idGym", idGym);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal object? SetUserIntermittentFasting(long id, bool? intermittentFasting)
        {
            string query = "UPDATE [User] SET IntermittentFasting = @_intermittentFasting WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_intermittentFasting", intermittentFasting);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal object? DeleteUserById(long id)
        {
            string query = "DELETE FROM [User] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal object? DeleteUserByMail(string? mail)
        {
            string query = "DELETE FROM [User] WHERE Mail = @_mail";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_mail", mail);

            return DatabaseManager<object?>.GetInstance().MakeQueryOneResult(cmd);
        }
    }
}
