using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Store_Manager;
using Store_Manager.Data;
using Store_Manager.Repositories;
using Store_Manager.Seeds;
using System.Text.Json.Serialization;
var builder = WebApplication.CreateBuilder(args);

//avoids recursive call to references to the relation inside each entity class. OrderItem to Order and then back to OrderItem
builder.Services.AddControllers()
        .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        });

//connection to the db
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
//put all the repo registrations in ServiceRegistration for cleaner look
ServiceRegistration.RegisterServices(builder.Services);

//CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsPolicy", builder =>
    {
        builder
            .WithOrigins("http://localhost:8080")
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();
app.UseCors("MyCorsPolicy");
app.MapControllers();

//seeder
// Initialize database context
/*
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<MyDbContext>();
    var productSeeder = new ProductSeeder(context);


    productSeeder.SeedProducts();
}
*/




app.MapGet("/", () => "Hello World!");
app.MapGet("/test1", () => "test1");

app.Run();
