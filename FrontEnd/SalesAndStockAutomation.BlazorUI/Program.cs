using Blazored.Toast;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using SalesAndStockAutomation.BlazorUI;
using SalesAndStockAutomation.Configurations;
using SalesAndStockAutomation.Services.Abstracts;
using SalesAndStockAutomation.Services.Concretes;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

#region Components
builder.Services.AddRadzenComponents();
builder.Services.AddBlazoredToast();
#endregion

#region Configurations
builder.Services.AddScoped<IDomainService, DomainManager>();
#endregion

#region Services
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IAuthorityService, AuthorityService>();
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ISaleService, SaleService>();
builder.Services.AddScoped<IStockService, StockService>();
builder.Services.AddScoped<IUserAuthorityService, UserAuthorityService>();
#endregion

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
