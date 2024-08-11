using MongoDB.Driver;
using System.Data.Entity;
using thecoolingeffect_api.Models;
using static thecoolingeffect_api.TextConstants.TextConstants;

namespace thecoolingeffect_api.Services
{
  /// <summary>
  /// About Service Class
  /// </summary>
  public class AboutService : IAboutService
  {
    private readonly ModelDbContext dbContext;
    private readonly ILogger<AboutService> logger;

    /// <summary>
    /// Initialises a new instance of <see cref="AboutService"/>
    /// </summary>
    /// <param name="logger"></param>
    public AboutService(ModelDbContext dbContext, ILogger<AboutService> logger)
    {
      this.dbContext = dbContext;
      this.logger = logger;
    }

    /// <summary>
    /// Get About Page Details
    /// </summary>
    /// <returns>About Detail Object.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    public async Task<AboutDetail> GetAboutPageDetailsAsync()
    {
      try
      {
        this.logger.LogInformation(Information.FetchingAboutDetails);

        var aboutDetails = await dbContext.AboutDetails.Find(_ => true).FirstOrDefaultAsync().ConfigureAwait(false)
          ?? throw new ArgumentNullException(Errors.AboutDetailsNotFound);

        return aboutDetails;
      }
      catch (Exception ex)
      {
        this.logger.LogError(ex, Errors.FailedToFetchAboutDetails);
        throw new InvalidOperationException(Errors.FailedToFetchAboutDetails);
      }
    }
  }
}
