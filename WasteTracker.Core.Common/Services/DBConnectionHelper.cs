using System.Data.SqlClient;
using WasteTracker.Core.Common.Models;
//db connection
namespace WasteTracker.Core.Common.Services
{
    public static class DBConnectionHelper 
    {
        public static string ConnectionString(DatabaseAppSettings appSettings)
        {
            string dataSource;
            string userid;
            string password;
            string initialCatalog;

#if DEBUG
            dataSource = appSettings.DBServerDev;
            initialCatalog = appSettings.DBDatabaseNameDev;
            userid = appSettings.DBUsernameDev;
            password = EncryptDecrypt.Decrypt(appSettings.DBPasswordDev);

#else
               dataSource = appSettings.DBServerProduction;
                initialCatalog = appSettings.DBDatabaseNameProduction;
                userid = appSettings.DBUsernameProduction;
                password = EncryptDecrypt.Decrypt(appSettings.DBPasswordProduction);
 
#endif

            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder
            {
                DataSource = dataSource,
                InitialCatalog = initialCatalog,
                PersistSecurityInfo = true,
                MultipleActiveResultSets = true,
                UserID = userid,
                Password = password,
                MaxPoolSize = 300
            };
            return sqlBuilder.ConnectionString;
        }
    }
}