using Microsoft.AspNetCore.Mvc;
using TorqueToToe.Services;

namespace TorqueToToe;

[ApiController]
[Route("v1/tesla")]
public class TeslaApiController : ControllerBase
{
  private readonly ITorqueStorageService _storageService;

  public TeslaApiController(ITorqueStorageService storageService)
  {
    _storageService = storageService;
  }

  /// <summary>
  /// Returns products mapped to user
  /// </summary>
  /// <response code="200">Returns products mapped to user</response>
  [HttpGet("api/1/products")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  public ActionResult ListProducts()
  {
    return Ok();
  }

  /// <summary>
  /// Returns information about a vehicle
  /// </summary>
  /// <response code="200">Returns information of the vehicle</response>
  /// <response code="404">The vehicle not found</response>
  [HttpGet("api/1/vehicles/{vehicle_id:int}")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status404NotFound)]
  public ActionResult GetVehicle(int vehicle_id)
  {
    return Ok();
  }

  /// <summary>
  /// Returns detailed data about a vehicle
  /// </summary>
  /// <response code="200">Returns detailed data of the vehicle</response>
  /// <response code="404">The vehicle not found</response>
  [HttpGet("api/1/vehicles/{vehicle_id:int}/vehicle_data")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status404NotFound)]
  public ActionResult GetVehicleData(int vehicle_id)
  {
    return Ok();
  }
}
