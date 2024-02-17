using Microsoft.AspNetCore.Mvc;
using Serilog;
using TorqueToToe.Models.Torque;
using TorqueToToe.Services;

namespace TorqueToToe.Controllers;

[ApiController]
[Route("v1/torque")]
public class TorqueController : ControllerBase
{
  private readonly IStorageService _storageService;

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
    Log.Debug("Received Torque data: {TorqueData}", torqueData);

    // Torque requires the upload endpoint to respond "OK!"
    return Ok("OK!");
  }
}
