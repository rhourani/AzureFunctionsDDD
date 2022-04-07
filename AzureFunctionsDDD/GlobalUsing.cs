global using AutoMapper;
global using AzureFunctionsDDD.Cosmos.Core.Configuration;
global using AzureFunctionsDDD.Cosmos.Core.Infrastructure.DependencyManagement;
global using AzureFunctionsDDD.Cosmos.Data.DataProviders;
global using AzureFunctionsDDD.Cosmos.Dto.Customers;
global using AzureFunctionsDDD.Cosmos.Services.GreetingService;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.Azure.Functions.Extensions.DependencyInjection;
global using Microsoft.Azure.WebJobs;
global using Microsoft.Azure.WebJobs.Extensions.Http;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Newtonsoft.Json;
global using System;
global using System.Data.SqlClient;
global using System.IO;
global using System.Threading.Tasks;
global using AzureFunctionsDDD.Cosmos.Core.ErrorMiddleware;


