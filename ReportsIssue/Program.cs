using AspNetCoreHero.ToastNotification;
using Microsoft.EntityFrameworkCore;
using ReportsIssue.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ReportsIssueDbContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("Conn")));


builder.Services.AddNotyf(config => { config.DurationInSeconds = 10; config.IsDismissable = true; config.Position = NotyfPosition.BottomRight; });

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
