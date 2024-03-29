global using ComputerSpace.Client.Services.AddressService;
global using ComputerSpace.Client.Services.AuthService;
global using ComputerSpace.Client.Services.CategoryService;
global using ComputerSpace.Client.Services.OrderService;
global using ComputerSpace.Client.Services.ProductService;
global using ComputerSpace.Client.Services.ProductTypeService;
global using ComputerSpace.Shared;
global using Microsoft.AspNetCore.Components.Authorization;
global using System.Net.Http.Json;
using Blazored.LocalStorage;
using ComputerSpace.Client;
using ComputerSpace.Client.Services.CartService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IProductTypeService, ProductTypeService>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();



await builder.Build().RunAsync();
