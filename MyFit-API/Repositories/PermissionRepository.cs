using MyFit_API.Database;
using MyFit_Libs.Models;
using System.Data.SqlClient;

namespace MyFit_API.Repositories
{
    public class PermissionRepository
    {

        internal List<Permission>? GetAllPermission()
        {
            string query = "SELECT * FROM [Permission]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<Permission>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        public Permission? GetPermission(int id)
        {
            string query = "SELECT * FROM [Permission] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<Permission?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal bool ExistsPermission(int id)
        {
            string query = "SELECT COUNT(Id) FROM [Permission] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<bool>.GetInstance().MakeQueryOneResult(cmd);
        }

        public string? GetPermissionName(int id)
        {
            string query = "SELECT Name FROM [Permission] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        public byte? GetPermissionValue(int id)
        {
            string query = "SELECT Value FROM [Permission] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<byte?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void AddPermission(Permission permission)
        {
            string query = "INSERT INTO [Permission] (Name, Value) VALUES (@_name, @_value)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_name", permission.Name);
            cmd.Parameters.AddWithValue("@_value", permission.Value);

            DatabaseManager<Permission>.GetInstance().MakeQueryNoResult(cmd);
        }

        public void SetPermissionName(int id, string name)
        {
            string query = "UPDATE [Permission] SET Name = @_name WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_name", name);

            DatabaseManager<Permission>.GetInstance().MakeQueryNoResult(cmd);
        }

        public void SetPermissionValue(int id, byte value)
        {
            string query = "UPDATE [Permission] SET Value = @_value WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);
            cmd.Parameters.AddWithValue("@_value", value);

            DatabaseManager<Permission>.GetInstance().MakeQueryNoResult(cmd);
        }

        public void DeletePermission(int id)
        {
            string query = "DELETE FROM [Permission] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<Permission>.GetInstance().MakeQueryNoResult(cmd);
        }

    }
}
