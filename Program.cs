using Blazored.LocalStorage;
using Blazored.Toast;
using BlazorScrumApp;
using BlazorScrumApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { });
builder.Services.AddMudServices();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredToast();

builder.Services.AddScoped(sp =>
{
    var http = sp.GetService<HttpClient>();
    return new ScrumboardService(http);
});
await builder.Build().RunAsync();
