using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NewProject1.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<NewProject1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NewProject1Context") ?? throw new InvalidOperationException("Connection string 'NewProject1Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Rates}/{action=Index}/{id?}");

app.Run();
