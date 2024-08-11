using thecoolingeffect_api.Models;

namespace thecoolingeffect_api.Services
{
  /// <summary>
  /// About Service Interface
  /// </summary>
  public interface IAboutService
  {
    /// <summary>
    /// Get About Page Details
    /// </summary>
    /// <returns>About Detail Object.</returns>
    Task<AboutDetail> GetAboutPageDetailsAsync();
  }
}
