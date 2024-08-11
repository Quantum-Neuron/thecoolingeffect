using MongoDB.Driver;
using thecoolingeffect_api.Models;

namespace thecoolingeffect_api
{
  /// <summary>
  /// Generate Seed Data Class
  /// </summary>
  public class GenerateSeedData
  {
    private readonly ModelDbContext dbContext;

    public GenerateSeedData(ModelDbContext dbContext)
    {
      this.dbContext = dbContext;
    }

    /// <summary>
    /// Seed data to MongoDB
    /// </summary>
    public void Seed()
    {
      if (dbContext.AboutDetails.CountDocuments(FilterDefinition<AboutDetail>.Empty) == 0) // Check if there is no seed data already.
      {
        var details = new AboutDetail()
        {
          FirstName = "Dwayne",
          LastName = "Meintjes",
          Joke = "The owner of the tuxedo store kept hovering over me when i was browsing, so I asked him to leave me alone. He said, “Fine, suit yourself."
        };

        dbContext.AboutDetails.InsertOne(details);
      }
    }
  }
}
