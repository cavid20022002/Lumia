using LumiaProject.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(opt =>
opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();



app.MapControllerRoute(
    name: "Default",
    pattern: "{area:exists}/{controller=dashboard}/{action=index}/{id?}"

    );
app.MapControllerRoute(
    name:"Default",
    pattern:"{controller=home}/{action=index}/{id?}"
    
    );
app.UseRouting();
app.UseStaticFiles();

app.Run();

