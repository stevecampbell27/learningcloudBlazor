using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace MyBlazorWasmApp.Client
{
    public class Startup
    {
        public async Task ConfigureServices(WebAssemblyHostBuilder builder)
        {
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            // Other services
        }

        public void Configure(WebAssemblyApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
