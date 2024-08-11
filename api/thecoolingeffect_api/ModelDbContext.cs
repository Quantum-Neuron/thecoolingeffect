using Microsoft.Extensions.Options;
using MongoDB.Driver;
using thecoolingeffect_api.Models;
using static thecoolingeffect_api.TextConstants.TextConstants;

namespace thecoolingeffect_api
{
  /// <summary>
  /// Model Database Context Class
  /// </summary>
  public class ModelDbContext
  {
    private readonly IMongoDatabase mongoDatabase;

    /// <summary>
    /// Initialises a new instance of <see cref="ModelDbContext"/>
    /// </summary>
    /// <param name="configuration"></param>
    public ModelDbContext(IOptions<DatabaseSettings> settings)
    {
      if (string.IsNullOrEmpty(settings.Value.ConnectionString) || string.IsNullOrEmpty(settings.Value.DatabaseName))
      {
        throw new InvalidOperationException(Errors.InvalidDatabaseSettings);
      }

      var client = new MongoClient(settings.Value.ConnectionString);
      mongoDatabase = client.GetDatabase(settings.Value.DatabaseName);
    }
    public IMongoCollection<AboutDetail> AboutDetails => mongoDatabase
      .GetCollection<AboutDetail>("AboutDetails");
  }
}
