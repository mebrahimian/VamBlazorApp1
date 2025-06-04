using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using VamBlazor.Client.Data;
using Microsoft.Extensions.DependencyInjection;
using DAL;
using Serilog;
using VamBlazor.Client.Application.Services;
using VamBlazor.Client.Application.Dto_Utilities;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
//using static VamBlazor.Client.Pages.PageQVam;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<EmailService>();
builder.Services.AddMudServices();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        options => options.CommandTimeout(3000)));

builder.Services.AddScoped<IUserService, UserService>();
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.File("logs/VamApp.log", rollingInterval: RollingInterval.Day) // لاگ‌ها در فایل
    .CreateLogger();

// اضافه کردن Serilog به سیستم لاگینگ ASP.NET Core
builder.Host.UseSerilog();
builder.Services.AddScoped<PersonServices>();
builder.Services.AddScoped<SandoghService, SandoghService>();
builder.Services.AddSingleton<DateService>();  // چدول تاریخ را به حافظه می آورد
builder.Services.AddScoped<DtoComparer>();
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddBlazoredLocalStorage(); // برای ذخیره‌سازی در localStorage
builder.Services.AddScoped<IUserService, UserService>(); // برای اعتبارسنجی کاربر

builder.Services.AddBlazoredLocalStorage(); // برای استفاده از LocalStorage
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>(); // ثبت CustomAuthenticationStateProvider به‌عنوان AuthenticationStateProvider
builder.Services.AddAuthorizationCore(); // برای احراز هویت در Blazor


//builder.Services.AddSingleton<CityService>();

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
app.UseAuthentication();
app.UseAuthorization();

app.Run();
