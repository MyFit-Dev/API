namespace MtFit_API.Database
{
    public class DatabaseInfo
    {
        public static string? ConnectionString { get; set; }

        public string? DatabaseServerName { get; set; } 
        public string? DatabaseName { get; set; }
        public bool IntegratedSecurity { get; set; }

        public DatabaseInfo(string connectionString) {

            //"data source=localhost\\SQLEXPRESS;initial catalog=MyFit;integrated security=true"

        }


    }
}
