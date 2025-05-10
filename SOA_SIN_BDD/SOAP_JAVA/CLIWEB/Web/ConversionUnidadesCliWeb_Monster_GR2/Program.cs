var builder = WebApplication.CreateBuilder(args);

// Configurar la ubicación personalizada de las vistas
builder.Services.AddControllersWithViews()
    .AddRazorOptions(options =>
    {
        options.ViewLocationFormats.Clear();
        options.ViewLocationFormats.Add("/ec.edu.monster.vista/{1}/{0}.cshtml");
        options.ViewLocationFormats.Add("/ec.edu.monster.vista/Shared/{0}.cshtml");
    });

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
    pattern: "{controller=Home}/{action=Login}/{id?}");
    //pattern: "{controller=Home}/{action=Conversor}/{id?}");

app.Run();
