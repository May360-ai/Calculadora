using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Calculadora.Frontend;
using Calculadora.Frontend.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configurar HttpClient para conectar al backend
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5007") });
builder.Services.AddScoped<IRegistroService, RegistroService>();
await builder.Build().RunAsync();
