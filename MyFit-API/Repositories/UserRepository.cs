using MyFit_API.Database;
using MyFit_Libs.Models;
using System.Data.SqlClient;

namespace MyFit_API.Repositories
{
    public class UserRepository
    {

        internal User? GetUserById(long id)
        {
            string query = "SELECT * FROM Users WHERE id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);
            return DatabaseManager<User>.GetInstance().MakeQueryOneResult(cmd);
        }


    }
}
