using thecoolingeffect_api.Models;

namespace thecoolingeffect_api.Services
{
  /// <summary>
  /// About Service Interface
  /// </summary>
  public interface IAboutService
  {
    Task<AboutDetail> GetAboutPageDetailsAsync();
  }
}
