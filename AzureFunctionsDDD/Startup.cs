using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
[assembly: FunctionsStartup(typeof(AzureFunctionsDDD.Startup))]
namespace AzureFunctionsDDD
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHttpClient();
            builder.Services.AddAutoMapper(typeof(Startup));
            //builder.Services. UseMiddleware<ExceptionLoggingMiddleware>();
            DependencyRegistrar.Register(builder.Services);
        }
    }
}