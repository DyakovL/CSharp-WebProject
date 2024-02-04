using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SurRon_VIN.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SurRon_VINContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SurRon_VINContext") ?? throw new InvalidOperationException("Connection string 'SurRon_VINContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


//bool dataValidation(string username, string password)
//{ 
//    string result = SurRon_VINContext cont
//    return false;
//}