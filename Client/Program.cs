using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SpellGenerator.Client;
using SpellGenerator.Client.Data;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<BuffTemplateService>();
builder.Services.AddSingleton<DebuffTemplateService>();
builder.Services.AddSingleton<UtilityTemplateService>();
builder.Services.AddSingleton<PenaltyTemplateService>();
builder.Services.AddSingleton<RequiredMaterialsTemplateService>();
builder.Services.AddSingleton<AestheticShapeTemplateService>();
builder.Services.AddSingleton<AestheticAdjectiveTemplateService>();
builder.Services.AddSingleton<AestheticMaterialsTemplateService>();
builder.Services.AddSingleton<DataTemplateService>();


await builder.Build().RunAsync();
