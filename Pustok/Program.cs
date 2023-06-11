
using Pustok.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();




builder.Services.AddDbContext<RelationsBooksShop>(opt => { 

    opt.UseSqlServer("Server=DESKTOP-8R6MOBB\\SQLEXPRESS;Database=PustokBooksStore;Integrated Security=true");

});
var app = builder.Build();
app.MapControllerRoute("default", "{controller=Home}/{action=index}/{id?}");
app.UseStaticFiles();

app.Run();
