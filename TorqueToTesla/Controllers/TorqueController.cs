using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using TorqueToTesla.Models;

namespace TorqueToTesla.Controllers;

[ApiController]
[Route("v1/torque")]
public class TorqueController : ControllerBase
{
  private readonly IMemoryCache _memoryCache;
  
  // Torque requires the upload endpoint to respond "OK!"
  private const string successMessage = "OK!";

    public TorqueController(IMemoryCache memoryCache)
    {
      _memoryCache = memoryCache;
    }

  /// <summary>
  /// Store vehicle data from Torque Android App
  /// </summary>
  /// <returns>"OK!"</returns>
  /// <response code="200">Returns the text "OK!"</response>
  [HttpGet("upload")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  public async Task<ActionResult> UploadTorque([FromQuery] TorqueDataDTO torqueData)
  {
    return Ok(torqueData);
    // return Ok(successMessage);
  }
}
