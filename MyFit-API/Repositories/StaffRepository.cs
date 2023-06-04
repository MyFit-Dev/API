using MyFit_API.Database;
using MyFit_Libs.Models;
using Newtonsoft.Json.Bson;
using System.Data.SqlClient;

namespace MyFit_API.Repositories
{
    public class StaffRepository
    {

        internal List<Staff>? GetAllStaff()
        {
            string query = "SELECT * FROM [Staff]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<Staff>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal Staff? GetStaff(long id)
        {
            string query = "SELECT * FROM [Staff] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<Staff?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal List<long>? GetStaffByGym(long idGym)
        {
            string query = "SELECT Id FROM [Staff] WHERE IdGym = @_idGym";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_idGym", idGym);

            return DatabaseManager<List<long>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal bool ExistsStaff(long id)
        {
            string query = "SELECT COUNT(Id) FROM [Staff] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<bool>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void AddStaff(Staff staff)
        {
            string query = "INSERT INTO [Staff] (IdUser, IdType, IdGym) VALUES (@_idUser, @_idType, @_idGym)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_idUser", staff.IdUser);
            cmd.Parameters.AddWithValue("@_idType", staff.IdType);
            cmd.Parameters.AddWithValue("@_idGym", staff.IdGym);

            DatabaseManager<Staff>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void DeleteStaff(long id)
        {
            string query = "DELETE FROM [Staff] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<Staff>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteStaffByGym(long idGym)
        {
            string query = "DELETE FROM [Staff] WHERE IdGym = @_idGym";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_idGym", idGym);

            DatabaseManager<Staff>.GetInstance().MakeQueryNoResult(cmd);
        }

    }
}
