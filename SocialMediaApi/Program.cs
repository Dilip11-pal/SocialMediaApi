using Microsoft.EntityFrameworkCore;
using SocialMediaData.Data;
using SocialMediaData.Models;
using SocialMediaData.Repository.Interface;
using SocialMediaData.Repository.Business;
using SocialMediaData.UnitofWork;
using SocialMediaBusiness.Manager;
using SocialMediaBusiness.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddOpenApi();

// Add controllers
builder.Services.AddControllers();

// DbContext
builder.Services.AddDbContext<SocialMediaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Dependency Injection
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<UnitOfWork>();
builder.Services.AddScoped<IUserManager, UserManager>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Map controller endpoints
app.MapControllers();

app.Run();
