﻿using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
//^^
//{[{
using ClientApp.Services;
//}]}
using System.Threading.Tasks;

namespace ClientApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddBaseAddressHttpClient();
            //^^
            //{[{
            builder.Services.AddScoped<WeatherForecastService>();
            //}]}
            builder.Services.AddTelerikBlazor();

            await builder.Build().RunAsync();
        }
    }
}