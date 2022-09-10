using Microsoft.EntityFrameworkCore;
using SysInventarios.DataContext;

var builder = WebApplication.CreateBuilder(args);

//para leer el archivo appsettings
ConfigurationManager configuration = builder.Configuration;

//se crea la conexion
var cnn = configuration.GetConnectionString("InventariosDbContext");

//se agrega el DbContext a la base datos
builder.Services.AddDbContext<InventariosDbContext>(options => options.UseSqlServer(cnn));

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
