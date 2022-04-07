namespace AzureFunctionsDDD.Cosmos.Services.GreetingService
{
    public interface IGreetingService
    {
        CustomerDTO FullName(CustomerDTO customer);
    }
}
