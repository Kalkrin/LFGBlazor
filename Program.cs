global using Microsoft.AspNetCore.Components.Authorization;
global using Blazored.LocalStorage;
using LFGWebApp.Data;
using LFGWebApp;

var builder = WebApplication.CreateBuilder(args);
var secretConfig = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddHttpClient();

//builder.Services.AddScoped(sp => new HttpClient{BaseAddress = new Uri("https://localhost:7205")});
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(secretConfig["apiurl"]) });
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddScoped<AuthService, AuthService>();
builder.Services.AddScoped<UserService, UserService>();
builder.Services.AddScoped<GameService, GameService>();
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
