using Microsoft.AspNetCore.Mvc;
using thecoolingeffect_api.Models;
using thecoolingeffect_api.Services;

namespace thecoolingeffect_api.Controllers
{
  /// <summary>
  /// About Controller Class
  /// </summary>
  [ApiController]
  [Route("api/[controller]")]
  public class AboutController : ControllerBase
  {
    private IAboutService aboutService;

    /// <summary>
    /// Initialises a new instance of <see cref="AboutController"/>
    /// </summary>
    /// <param name="aboutService"></param>
    public AboutController(IAboutService aboutService)
    {
      this.aboutService = aboutService;
    }

    /// <summary>
    /// Get personal details.
    /// </summary>
    /// <returns></returns>
    [HttpGet("details")]
    public Task<AboutDetail> GetAboutPageDetailsAsync()
    {
      return this.aboutService.GetAboutPageDetailsAsync();
    }
  }
}
