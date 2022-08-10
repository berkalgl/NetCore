using ECommerce.Data;
using ECommerce.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddScoped<IProductService,MockProductService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IUserService, FakeUserService>();

//Set Session
builder.Services.AddSession();

var connectionString = builder.Configuration.GetConnectionString("db");
//var config = builder.Configuration.GetSection("key")["key"];

builder.Services.AddDbContext<ECommerceDbContext>(option => option.UseSqlServer(connectionString));

//Authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option =>
    {
        option.LoginPath = "/User/Login";
        option.AccessDeniedPath = "/User/AccessDenied";
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//get the instance of dbcontext which is scoped service
var dbContext = app.Services.CreateScope().ServiceProvider.GetRequiredService<ECommerceDbContext>();

Console.WriteLine("DB Initialization");
//prepare DB
PrepareDb.SeedData(dbContext);

app.UseHttpsRedirection();
app.UseStaticFiles();

// Adding session to middleware
app.UseSession();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
