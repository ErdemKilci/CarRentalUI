using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CarRentalUI;
using MudBlazor.Services;
using MudBlazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Sett baseadresse til API-et, kaller API-et fra CARRENTALAPIs localhost
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5057/") });
builder.Services.AddMudServices();
builder.Services.AddScoped<MudThemeProvider>();

await builder.Build().RunAsync();
