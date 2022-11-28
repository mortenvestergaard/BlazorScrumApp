using BlazorScrumApp;
using BlazorScrumApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7025/api/") });
builder.Services.AddMudServices();

builder.Services.AddScoped(sp =>
{
    var http = sp.GetService<HttpClient>();
    return new ScrumboardService(http);
});
//builder.Services.AddSingleton<IScrumboardService, ScrumboardService>();


await builder.Build().RunAsync();
