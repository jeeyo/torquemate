using Microsoft.AspNetCore.Mvc;
using TorqueToTesla.Models;
using TorqueToTesla.Services;

namespace TorqueToTesla.Controllers;

[ApiController]
[Route("v1/torque")]
public class TorqueController : ControllerBase
{
  private readonly IStorageService _storageService;

  // Torque requires the upload endpoint to respond "OK!"
  private const string successMessage = "OK!";

  public TorqueController(IStorageService storageService)
  {
    _storageService = storageService;
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
