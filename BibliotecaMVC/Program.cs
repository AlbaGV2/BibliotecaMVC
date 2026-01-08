using BibliotecaMVC.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Para acceder a la base de datos y poder crear MydbContext.

//INI: EF conf para entityframe.. inyeccion por dependencias
string cnnString = builder.Configuration.GetConnectionString("DefaultConnection") ?? "";
//disponible en todos los controladores del proyecto.Con un contructor
builder.Services.AddDbContext<MyDbContext>(options =>
options.UseSqlServer(cnnString));




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
