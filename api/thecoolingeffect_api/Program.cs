using Microsoft.Extensions.Options;
using MongoDB.Driver;
using thecoolingeffect_api;
using thecoolingeffect_api.Models;
using thecoolingeffect_api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<DatabaseSettings>(builder
  .Configuration.GetSection(nameof(DatabaseSettings)));

builder.Services.AddSingleton(sp =>
  sp.GetRequiredService<IOptions<DatabaseSettings>>().Value); // Register the DatabaseSettings

builder.Services.AddSingleton<IMongoClient, MongoClient>(sp => // Set up the MongoDB client
{
  var settings = sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
  return new MongoClient(settings.ConnectionString);
});

builder.Services.AddSingleton<ModelDbContext>(); // Register the ModelDbContext
builder.Services.AddSingleton<IAboutService, AboutService>(); // Register the AboutService
builder.Services.AddTransient<GenerateSeedData>(); // Register the GenerateSeedData

builder.Services.AddControllers();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
  var services = scope.ServiceProvider;
  var seedData = services.GetRequiredService<GenerateSeedData>();
  seedData.Seed();
}

app.UseHttpsRedirection();
app.UseDeveloperExceptionPage();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();