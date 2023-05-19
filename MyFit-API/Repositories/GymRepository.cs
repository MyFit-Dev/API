using MyFit_API.Database;
using MyFit_Libs.Models;
using System.Data.SqlClient;

namespace MyFit_API.Repositories
{
    public class GymRepository
    {

        internal List<Gym>? GetAllGyms()
        {
            string query = "SELECT * FROM [Gym]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<Gym>>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal Gym? GetGym(long id)
        {
            string query = "SELECT * FROM [Gym] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            return DatabaseManager<Gym?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetGymName(long id)
        {
            string query = "SELECT Name FROM [Gym] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal long GetGymIdStaff(long id)
        {
            string query = "SELECT IdStaff FROM [Gym] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            return DatabaseManager<long>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetGymState(long id)
        {
            string query = "SELECT State FROM [Gym] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetGymCity(long id)
        {
            string query = "SELECT City FROM [Gym] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetGymStreet(long id)
        {
            string query = "SELECT Street FROM [Gym] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal int GetGymCivicNumber(long id)
        {
            string query = "SELECT CivicNumber FROM [Gym] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            return DatabaseManager<int>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal int GetGymCAP(long id)
        {
            string query = "SELECT CAP FROM [Gym] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);
            return DatabaseManager<int>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void AddGym(Gym gym)
        {
            string Name = gym.Name, State = gym.State, City = gym.City, Street = gym.Street;
            int CivicNumber = gym.CivicNumber, CAP = gym.CAP;
            long IdStaff = gym.IdStaff;

            string query = "INSERT INTO [Gym] ([Name],[IdStaff],[State],[City],[Street],[CivicNumber],[CAP]) VALUES (@_name,@_idStaff,@_state,@_city,@_street,@_civicNumber,@_cap)";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_name", Name);
            cmd.Parameters.AddWithValue("@_idStaff", IdStaff);
            cmd.Parameters.AddWithValue("@_state", State);
            cmd.Parameters.AddWithValue("@_city", City);
            cmd.Parameters.AddWithValue("@_street", Street);
            cmd.Parameters.AddWithValue("@_civicNumber", CivicNumber);
            cmd.Parameters.AddWithValue("@_cap", CAP);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetGymName(long id, string name)
        {
            string query = "UPDATE [Gym] SET Name = @_name WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_name", name);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetGymState(long id, string state)
        {
            string query = "UPDATE [Gym] SET State = @_state WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_state", state);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetGymCity(long id, string city)
        {
            string query = "UPDATE [Gym] SET City = @_city WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_city", city);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetGymStreet(long id, string street)
        {
            string query = "UPDATE [Gym] SET Street = @_street WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_street", street);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetGymCivicNumber(long id, int civicNumber)
        {
            string query = "UPDATE [Gym] SET CivicNumber = @_civicNumber WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_civicNumber", civicNumber);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetGymCAP(long id, int cap)
        {
            string query = "UPDATE [Gym] SET Cap = @_cap WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_cap", cap);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteGym(long id)
        {
            string query = "DELETE FROM [Gym] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal int CountAllGym()
        {
            string query = "SELECT COUNT * FROM [Gym]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<int>.GetInstance().MakeQueryOneScalarResult(cmd);
        }

        internal int CountGymStaffers()
        {
            string query = "SELECT COUNT(s.IdUser) FROM [Gym] g JOIN [Staff] s ON g.IdStaff = s.Id";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<int>.GetInstance().MakeQueryOneScalarResult(cmd);
        }

    }
}
