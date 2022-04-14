namespace WasteTracker.Core.Common.Models
{
    public class DatabaseAppSettings
    {
        public string DBDatabaseNameProduction { get; set; }
        public string DBServerProduction { get; set; }
        public string DBPasswordProduction { get; set; }
        public string DBUsernameProduction { get; set; }
        public string DBUsernameDev { get; set; }
        public string DBPasswordDev { get; set; }
        public string DBDatabaseNameDev { get; set; }
        public string DBServerDev { get; set; }
    }
}
