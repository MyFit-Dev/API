using MyFit_API.Database;
using MyFit_Libs.Models;
using System.Data.SqlClient;

namespace MyFit_API.Repositories
{
    public class StaffTypeRepository
    {

        internal List<StaffType>? GetAllStaffType()
        {
            string query = "SELECT * FROM [StaffType]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<StaffType>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal StaffType? GetStaffType(byte id)
        {
            string query = "SELECT * FROM [StaffType] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<StaffType?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal bool ExistsStaffType(byte id)
        {
            string query = "SELECT COUNT(Id) FROM [StaffType] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<bool>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetStaffTypeName(byte id)
        {
            string query = "SELECT Name FROM [StaffType] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void AddStaffType(StaffType staffType)
        {
            string query = "INSERT INTO [StaffType] (Name) VALUES (@_name)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_name", staffType.Name);

            DatabaseManager<StaffType>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetStaffTypeName(byte id, string name)
        {
            string query = "UPDATE [StaffType] SET Name = @_name WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_name", name);

            DatabaseManager<StaffType>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteStaffType(byte id)
        {
            string query = "DELETE FROM [StaffType] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<StaffType>.GetInstance().MakeQueryNoResult(cmd);
        }

    }
}
