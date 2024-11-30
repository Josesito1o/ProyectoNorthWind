using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddNorthWindServices(); 


using IHost AppHost = Builder.Build();



IAppLogger Logger =  AppHost.Services.GetRequiredService<IAppLogger>();
Logger.WriteLog("Aplication Started.");

IProductService Service = AppHost.Services.GetRequiredService<IProductService>();
Service.Add("Demo", "Azucar refinada");