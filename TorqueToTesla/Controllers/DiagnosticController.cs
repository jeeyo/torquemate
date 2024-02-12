using Microsoft.AspNetCore.Mvc;
using TorqueToTesla.Models;
using TorqueToTesla.Services;

namespace TorqueToTesla.Controllers;

[ApiController]
[Route("v1/diagnostics")]
public class DiagnosticController : ControllerBase
{
  private readonly IStorageService _storageService;

  // Torque requires the upload endpoint to respond "OK!"
  private const string successMessage = "OK!";

  public DiagnosticController(IStorageService storageService)
  {
    _storageService = storageService;
  }

  /// <summary>
  /// Returns the fake charge state
  /// </summary>
  /// <response code="200">Returns the fake charge state/response>
  [HttpGet("charge_state")]
  [ProducesResponseType(typeof(TeslaChargeState), StatusCodes.Status200OK, "application/json")]
  public ActionResult<TeslaChargeState> GetChargeState()
  {
    var chargeState = new TeslaChargeState{
      BatteryLevel = 100,
      UsableBatteryLevel = 100,
      Timestamp = (long)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalMilliseconds,
    };

    return Ok(chargeState);
  }

  /// <summary>
  /// Returns the fake climate state
  /// </summary>
  /// <response code="200">Returns the fake climate state/response>
  [HttpGet("climate_state")]
  [ProducesResponseType(typeof(TeslaClimateState), StatusCodes.Status200OK, "application/json")]
  public ActionResult<TeslaClimateState> GetClimateState()
  {
    var chargeState = new TeslaClimateState{
      IsClimateOn = true,
      IsAutoConditioningOn = false,

      DriverTempSetting = 21.0,
      PassengerTempSetting = 21.0,

      MaxAvailTemp = 28,
      MinAvailTemp = 15,

      FanStatus = 0,

      InsideTemp = 38.4,
      OutsideTemp = 36.5,
      Timestamp = (long)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalMilliseconds,
    };

    return Ok(chargeState);
  }
}
