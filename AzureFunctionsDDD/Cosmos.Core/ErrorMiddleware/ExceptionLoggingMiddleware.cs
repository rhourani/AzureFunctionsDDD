using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureFunctionsDDD.Cosmos.Core.ErrorMiddleware
{
    public class ExceptionLoggingMiddleware : IFunctionsWorkerMiddleware
    {
		public async Task Invoke(FunctionContext context, FunctionExecutionDelegate next)

		{
			try
			{
				await next(context);
			}
			catch (Exception ex)
			{
				//Todo add messages to some db log or console log
				var log = context.GetLogger<ExceptionLoggingMiddleware>();
			}
		}
	}
}
