using MtFit_API.Database;
using MyFit_API.Exceptions;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace MyFit_API.Database
{
    public class DatabaseManager<T>
    {
        private SqlConnection? _conn;

        /// <summary>
        /// Costruttore vuoto per creare istanze
        /// </summary>
        private DatabaseManager()
        {

        }


        public T? MakeQueryOneResult(SqlCommand sqlCommand)
        {
            CreateConnectionToDatabase();
            T? value = JsonConvert.DeserializeObject<T>(GetOneResult(sqlCommand));
            DeleteConnection();
            return value;
        }

        public T? MakeQueryOneScalarResult(SqlCommand sqlCommand)
        {
            CreateConnectionToDatabase();
            T? value = JsonConvert.DeserializeObject<T>(GetOneScalarResult(sqlCommand));
            DeleteConnection();
            return value;
        }

        public T? MakeQueryMoreResults(SqlCommand sqlCommand)
        {
            CreateConnectionToDatabase();
            T? value = JsonConvert.DeserializeObject<T>(GetAllResults(sqlCommand));
            DeleteConnection();
            return value;
        }

        public void MakeQueryNoResult(SqlCommand sqlCommand)
        {
            CreateConnectionToDatabase();
            GetNoneResult(sqlCommand);
            DeleteConnection();
        }


        public static DatabaseManager<T> GetInstance()
        {
            return new DatabaseManager<T>();
        }

        /// <summary>
        /// Instaura una connesione al database
        /// </summary>
        /// <param name="initialCatalog">Nome del database</param>
        /// <param name="datasource">Nome del server sql</param>
        /// <param name="integratedSecurity">integrated security</param>
        private void CreateConnectionToDatabase()
        {
            //significa che _conn ha gia un'istanza di SqlConnection
            if (checkConnectionDatabase())
                throw new Exception("Errore interno. Connessione gia aperta.");
            SqlConnectionStringBuilder connBuilder = new SqlConnectionStringBuilder();
            connBuilder.ConnectionString = DatabaseInfo.ConnectionString;
            _conn = new SqlConnection(connBuilder.ToString());
        }

        private void DeleteConnection()
        {
            _conn = null;
        }

        /// <summary>
        /// Viene usato per restituire la prima colonna trovata
        /// </summary>
        /// <param name="query">la query al db</param>
        /// <returns>Json con il dato trovato</returns>

        private string GetOneResult(SqlCommand cmd)
        {
            if (!checkConnectionDatabase())
            {
                throw new DatabaseException("Database connection not set");
            }
            using (var conn = _conn)
            {
                cmd.Connection = conn;
                conn.Open();
                var reader = cmd.ExecuteReader();
                IEnumerable<Dictionary<string, object>> result = Serialize(reader);
                string jsonResult = JsonConvert.SerializeObject(result);
                conn.Close();
                jsonResult = jsonResult.Replace("[", "").Replace("]", "");
                return jsonResult;
            }
        }

        private string GetOneScalarResult(SqlCommand cmd)
        {
            if (!checkConnectionDatabase())
            {
                throw new DatabaseException("Database connection not set");
            }
            using (var conn = _conn)
            {
                cmd.Connection = conn;
                conn.Open();
                var reader = cmd.ExecuteScalar();
                string jsonResult = JsonConvert.SerializeObject(reader);
                conn.Close();
                jsonResult = jsonResult.Replace("[", "").Replace("]", "");
                return jsonResult;
            }
        }


        protected IEnumerable<Dictionary<string, object>> Serialize(SqlDataReader reader)
        {
            var results = new List<Dictionary<string, object>>();
            var cols = new List<string>();
            for (var i = 0; i < reader.FieldCount; i++)
                cols.Add(reader.GetName(i));

            while (reader.Read())
                results.Add(SerializeRow(cols, reader));

            return results;
        }
        protected Dictionary<string, object> SerializeRow(IEnumerable<string> cols, SqlDataReader reader)
        {
            var result = new Dictionary<string, object>();
            foreach (var col in cols)
                result.Add(col, reader[col]);
            return result;
        }

        /// <summary>
        /// Viene usato per restituire tutte le colonne trovate
        /// </summary>
        /// <param name="query">La query al db</param>
        /// <returns></returns>
        private string GetAllResults(SqlCommand cmd)
        {
            if (!checkConnectionDatabase())
            {
                throw new DatabaseException("Database connection not set");
            }
            using (var conn = _conn)
            {
                cmd.Connection = conn;
                conn.Open();
                var values = new List<Dictionary<string, object>>();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    do
                    {
                        while (reader.Read())
                        {
                            var fieldValues = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                fieldValues.Add(reader.GetName(i), reader[i]);
                            }
                            values.Add(fieldValues);
                        }
                    } while (reader.NextResult());
                }
                conn.Close();
                var json = JsonConvert.SerializeObject(values);
                return json;

            }
        }

        /// <summary>
        /// Viene usato quando la query non prevede nessun dato in ritorno
        /// </summary>
        /// <param name="query">La query al db</param>
        private void GetNoneResult(SqlCommand cmd)
        {
            if (!checkConnectionDatabase())
                throw new DatabaseException("Database connection not set");
            using (var conn = _conn)
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        private bool checkConnectionDatabase()
        {
            return _conn != null;
        }
    }
}
