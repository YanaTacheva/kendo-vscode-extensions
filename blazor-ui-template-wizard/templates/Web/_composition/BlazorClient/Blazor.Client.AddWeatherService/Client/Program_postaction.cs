using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using System.Net.Http;
using System;
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
            builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            //^^
            //{[{
            builder.Services.AddScoped<WeatherForecastService>();
            //}]}
            builder.Services.AddTelerikBlazor();

            await builder.Build().RunAsync();
        }
    }
}
