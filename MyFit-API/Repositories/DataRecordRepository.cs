using MyFit_API.Database;
using MyFit_Libs.Models;
using System.Data.SqlClient;

namespace MyFit_API.Repositories
{
    public class DataRecordRepository
    {

        internal List<DataRecord>? GetAll()
        {
            string query = "SELECT * FROM [DataRecord]";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<DataRecord>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal DataRecord? GetById(long id)
        {
            string query = "SELECT * FROM [DataRecord] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<DataRecord?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal bool Exists(long id)
        {
            string query = "SELECT * FROM [DataRecord] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            
            cmd.Parameters.AddWithValue("@_id", id);

            return DatabaseManager<DataRecord?>.GetInstance().MakeQueryOneResult(cmd) != null;
        }

        internal List<DataRecord>? GetByUserId(long idUser)
        {
            string query = "SELECT * FROM [DataRecord] WHERE IdUser = @_idUser";
            SqlCommand cmd = new SqlCommand(query);
            
            cmd.Parameters.AddWithValue("@_idUser", idUser);

            return DatabaseManager<List<DataRecord>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal List<DataRecord>? GetByUserIdAndDate(long idUser, DateTime date)
        {
            string query = "SELECT * FROM [DataRecord] WHERE IdUser = @_idUser AND Date = @_date";
            SqlCommand cmd = new SqlCommand(query);
            
            cmd.Parameters.AddWithValue("@_idUser", idUser);
            cmd.Parameters.AddWithValue("@_date", date);

            return DatabaseManager<List<DataRecord>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal List<DataRecord>? GetByUserIdAndDateRange(long idUser, DateTime dateFrom, DateTime dateTo)
        {
            string query = "SELECT * FROM [DataRecord] WHERE IdUser = @_idUser AND Date BETWEEN @_dateFrom AND @_dateTo";
            SqlCommand cmd = new SqlCommand(query);
            
            cmd.Parameters.AddWithValue("@_idUser", idUser);
            cmd.Parameters.AddWithValue("@_dateFrom", dateFrom);
            cmd.Parameters.AddWithValue("@_dateTo", dateTo);

            return DatabaseManager<List<DataRecord>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal bool HasUnlockedRecord(long idUser, int idRecord)
        {
            string query = "SELECT * FROM [DataRecord] WHERE IdUser = @_idUser AND IdRecord = @_idRecord";
            SqlCommand cmd = new SqlCommand(query);
            
            cmd.Parameters.AddWithValue("@_idUser", idUser);
            cmd.Parameters.AddWithValue("@_idRecord", idRecord);

            return DatabaseManager<DataRecord?>.GetInstance().MakeQueryOneResult(cmd) != null;
        }

        internal int? GetLastUnlockedRecord(long idUser)
        {
            string query = "SELECT TOP 1 IdRecord FROM [DataRecord] WHERE IdUser = @_idUser ORDER BY Date DESC";
            SqlCommand cmd = new SqlCommand(query);
            
            cmd.Parameters.AddWithValue("@_idUser", idUser);

            return DatabaseManager<int?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal int? GetRecordId(long idUser, int idRecord)
        {
            string query = "SELECT Id FROM [DataRecord] WHERE IdUser = @_idUser AND IdRecord = @_idRecord";
            SqlCommand cmd = new SqlCommand(query);
            
            cmd.Parameters.AddWithValue("@_idUser", idUser);
            cmd.Parameters.AddWithValue("@_idRecord", idRecord);

            return DatabaseManager<int?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal void AddRecord(DataRecord dataRecord)
        {
            string query = "INSERT INTO [DataRecord] (IdRecord, IdUser, Date) VALUES (@_idRecord, @_idUser, @_date)";
            SqlCommand cmd = new SqlCommand(query);
            
            cmd.Parameters.AddWithValue("@_idRecord", dataRecord.IdRecord);
            cmd.Parameters.AddWithValue("@_idUser", dataRecord.IdUser);
            cmd.Parameters.AddWithValue("@_date", dataRecord.Date);

            DatabaseManager<DataRecord?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal int? GetUnlockedRecordsCount(long idUser)
        {
            string query = "SELECT COUNT(*) FROM [DataRecord] WHERE IdUser = @_idUser";
            SqlCommand cmd = new SqlCommand(query);
            
            cmd.Parameters.AddWithValue("@_idUser", idUser);

            return DatabaseManager<int?>.GetInstance().MakeQueryOneResult(cmd);
        }

        internal List<DataRecord>? GetUnlockedRecordsCount()
        {
            string query = "SELECT IdUser, COUNT(*) AS Count FROM [DataRecord] GROUP BY IdUser";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<DataRecord>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

        internal void SetDataRecordDate(long id, DateTime date)
        {
            string query = "UPDATE [DataRecord] SET Date = @_date WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            
            cmd.Parameters.AddWithValue("@_date", date);
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<DataRecord?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteDataRecord(long id)
        {
            string query = "DELETE FROM [DataRecord] WHERE Id = @_id";
            SqlCommand cmd = new SqlCommand(query);
            
            cmd.Parameters.AddWithValue("@_id", id);

            DatabaseManager<DataRecord?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteDataRecordByUserId(long idUser)
        {
            string query = "DELETE FROM [DataRecord] WHERE IdUser = @_idUser";
            SqlCommand cmd = new SqlCommand(query);
            
            cmd.Parameters.AddWithValue("@_idUser", idUser);

            DatabaseManager<DataRecord?>.GetInstance().MakeQueryNoResult(cmd);
        }

        internal void DeleteDataRecordByRecordId(int idRecord)
        {
            string query = "DELETE FROM [DataRecord] WHERE IdRecord = @_idRecord";
            SqlCommand cmd = new SqlCommand(query);
            
            cmd.Parameters.AddWithValue("@_idRecord", idRecord);

            DatabaseManager<DataRecord?>.GetInstance().MakeQueryNoResult(cmd);
        }






    }
}
