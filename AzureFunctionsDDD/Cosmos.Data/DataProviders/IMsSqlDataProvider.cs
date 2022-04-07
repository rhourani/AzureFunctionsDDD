namespace AzureFunctionsDDD.Cosmos.Data.DataProviders
{
    public interface IMsSqlDataProvider
    {
        SqlCommand CreateCommand(SqlConnection connection);
        SqlConnection CreateConnection();
    }
}
