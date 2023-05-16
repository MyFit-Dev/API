using MyFit_API.Database;
using MyFit_Libs.Models;
using System.Data.SqlClient;

namespace MyFit_API.Repositories
{
    public class UserRepository
    {

        internal User? GetUserById(long id)
        {
            string query = "SELECT * FROM [User] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);
            return DatabaseManager<User>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal User? GetUserByEmail(string mail)
        {
            string query = "SELECT * FROM [User] WHERE Mail = '@_mail'";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_mail", mail);
            return DatabaseManager<User>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal Plan GetUserPlan(long id)
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

        internal bool IsUserOnIntermittentFasting(long id)
        {
            string query = "SELECT IntermittentFasting FROM [User] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);
            return DatabaseManager<bool>.GetInstance().MakeQueryOneResult(cmd);
        }


    }
}
