namespace AzureFunctionsDDD.Cosmos.Core.Infrastructure.DependencyManagement
{
    public static class DependencyRegistrar
    {
        public static void Register(IServiceCollection services)
        {

            services.AddScoped<IGreetingService, GreetingService>();

            // DATA ACCESS LAYER
            services.AddTransient<IMsSqlDataProvider, MsSqlDataProvider>();
            /*
			 
			 AddSingleton() - Singleton service is created only one time per application and that single instance is used throughout the application life time.

            AddTransient() - This method creates a Transient service. A new instance of a Transient service is created each time it is requested.

            AddScoped() - This method creates a Scoped service. A new instance of a Scoped service is created once per request within the scope. For example, in a web application it creates 1 instance per each http request but uses the same instance in the other calls within that same web request.
			 
			 */


        }
    }
}
