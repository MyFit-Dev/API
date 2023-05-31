using MyFit_API.Database;
using MyFit_Libs.Models;
using System.Data.SqlClient;

namespace MyFit_API.Repositories
{
    public class LogRepository
    {

        internal List<Log>? GetAllLogs()
        {
            string query = "SELECT * FROM [Log]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<Log>>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal bool ExistsLog(long id)
        {
            string query = "SELECT COUNT(Id) FROM [Log] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<int>.GetInstance().MakeQueryOneResult(cmd) > 0;
        }

        internal Log? GetLog(long id)
        {
            string query = "SELECT * FROM [Log] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<Log>.GetInstance().MakeQueryMoreResults(cmd);        
        }

        internal string? GetLogText(long id)
        {
            string query = "SELECT Text FROM [Log] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal string? GetLogScope(long id)
        {
            string query = "SELECT Scope FROM [Log] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<string?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal DateTime? GetLogDate(long id)
        {
            string query = "SELECT Date FROM [Log] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<DateTime?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal long? GetLogUserId(long id)
        {
            string query = "SELECT IdUser FROM [Log] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<long?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal byte? GetLogValue(long id)
        {
            string query = "SELECT Value FROM [Log] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<byte?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void AddLog(Log log)
        {
            string Text = log.Text, Scope = log.Scope;
            DateTime Date = log.Date;
            long IdUser = log.IdUser;
            byte Value = log.Value;

            string query = "INSERT INTO ([Text],[Scope],[Date],[IdUser],[Value]) VALUES (@_text,@_scope,@_date,@_idUser,@_value)";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_text", Text);
            cmd.Parameters.AddWithValue("@_scope", Scope);
            cmd.Parameters.AddWithValue("@_date", Date);
            cmd.Parameters.AddWithValue("@_idUser", IdUser);
            cmd.Parameters.AddWithValue("@_value", Value);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetLogText(long id, string text)
        {
            string query = "UPDATE [Log] SET Text = @_text WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_text", text);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetLogScope(long id, string scope)
        {
            string query = "UPDATE [Log] SET Scope = @_scope WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_scope", scope);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetLogIdUser(long id, long? idUser)
        {
            string query = "UPDATE [Log] SET IdUser = @_idUser WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", idUser);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void SetLogValue(long id, byte? value)
        {
            string query = "UPDATE [Log] SET Value = @_value WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_value", value);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteLog(long id)
        {
            string query = "DELETE FROM [Log] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteUserLogs(long idUser)
        {
            string query = "DELETE FROM [Log] WHERE IdUser = @_idUser";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_idUser", idUser);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteLogsBefore(DateTime date)
        {
            string query = "DELETE FROM [Log] WHERE Date < @_date";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_date", date);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteLogsBetweenDates(DateTime startDate, DateTime finishDate)
        {
            string query = "DELETE FROM [Log] WHERE Date BETWEEN @_startDate AND @_finishDate";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_startDate", startDate);
            cmd.Parameters.AddWithValue("@_finishDate", finishDate);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteLogsByValue(byte value)
        {
            string query = "DELETE FROM [Log] WHERE Value = @_value";
            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@_value", value);

            DatabaseManager<object?>.GetInstance().MakeQueryNoResult(cmd);
        }

    }
}
