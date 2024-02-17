using Microsoft.AspNetCore.Mvc;
using Serilog;
using TorqueMate.Models.Torque;
using TorqueMate.Services;
using ILogger = Serilog.ILogger;

namespace TorqueMate.Controllers;

[ApiController]
[Route("v1/torque")]
public class TorqueController : ControllerBase
{
  private readonly ITorqueStorageService _torqueStorageService;
  private readonly ILogger _logger = Log.ForContext<TorqueController>();

  public TorqueController(ITorqueStorageService torqueStorageService)
  {
    _torqueStorageService = torqueStorageService;
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
    // TODO: Use Bearer token as Device ID if provided

    _logger.Information("Torque data uploaded: {TorqueData}", torqueData);
    await _torqueStorageService.StoreTorqueData(torqueData);

    // Torque requires the upload endpoint to respond "OK!"
    return Ok("OK!");
  }
}
