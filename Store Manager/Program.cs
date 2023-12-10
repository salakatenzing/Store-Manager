using Microsoft.EntityFrameworkCore;
using Store_Manager.Models;
using Store_Manager.Repositories;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ProductRepository>();

var app = builder.Build();
app.MapControllers();





app.MapGet("/", () => "Hello World!");
app.MapGet("/test1", () => "test1");

app.Run();
