using ECommerce.Business;
using ECommerce.Data.Data;
using ECommerce.Data.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("ECommerceDb");
builder.Services.AddDbContext<ECommerceDbContext>(option => option.UseSqlServer());

builder.Services.AddScoped<IProductRepository, EFProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IUserService, FakeUserService>();

var issuer = "dummy.com.tr";
var audience = "dummy.com.tr";
var secret = "a-secret-sentence";

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(opt =>
                {
                    opt.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateActor = true,
                        ValidateAudience = true,
                        ValidateIssuer = true,
                        ValidAudience = audience,
                        ValidIssuer = issuer,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret))
                    };
                });

builder.Services.AddCors(option =>
{
    option.AddPolicy("allow", builder =>
    {
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
        // two different sub domains are two different origins
        builder.AllowAnyOrigin();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("allow");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
