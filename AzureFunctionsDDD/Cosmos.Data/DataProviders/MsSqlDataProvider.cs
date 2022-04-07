namespace AzureFunctionsDDD.Cosmos.Data.DataProviders
{
    public class MsSqlDataProvider : IMsSqlDataProvider
    {
        private readonly IConfiguration _configuration;
        public MsSqlDataProvider(IConfiguration config)
        {
            _configuration = config;
        }

        /// <summary>
        ///  Create a new SQL connection object
        /// </summary>
        /// <returns>SQL connction object</returns>
        public SqlConnection CreateConnection()
        {
            return new(_configuration.GetConnectionString(CosmosSettingKeysDefault.MsSqlConnectionStringKey));
        }


        /// <summary>
        /// Create a command object on the passed connection
        /// </summary>
        /// <param name="connection">SQL db connection object</param>
        /// <returns>SQL command object</returns>
        public SqlCommand CreateCommand(SqlConnection connection)
        {
            return connection.CreateCommand();
        }
    }
}
