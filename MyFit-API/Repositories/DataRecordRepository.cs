using MyFit_API.Database;
using MyFit_Libs.Models;
using System.Data.SqlClient;

namespace MyFit_API.Repositories
{
    public class DataRecordRepository
    {

        internal List<DataRecord>? GetAll()
        {
            string query = "SELECT * FROM DataRecord";
            SqlCommand cmd = new SqlCommand(query);

            return DatabaseManager<List<DataRecord>?>.GetInstance().MakeQueryMoreResults(cmd);
        }

    }
}
