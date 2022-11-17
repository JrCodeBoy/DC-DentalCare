using DC_DentalCare.BaseDeDatos;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(ConfiguracionCookie);
        services.AddSession();
        services.AddControllersWithViews();
        services.AddDbContext<DentalCareDB>(options => options.UseSqlite(@"filename=C:\Users\valet\Documents\GitHub\DentalCare\DC DentalCare\Database.db"));

    }

    public static void ConfiguracionCookie(CookieAuthenticationOptions opciones)
    {
        opciones.LoginPath = "/Login/Login";
        opciones.AccessDeniedPath = "/Login/NoAutorizado";
        opciones.LogoutPath = "/Login/Logout";
        opciones.ExpireTimeSpan = System.TimeSpan.FromMinutes(60);
    }


    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.UseAuthentication();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Login}/{action=Login}/{id?}");
        });
        app.UseCookiePolicy();
    }
}