using Microsoft.AspNetCore.Mvc;
using TorqueToTesla.Services;

namespace TorqueToTesla;

[ApiController]
[Route("v1/tesla")]
public class TeslaApiController : ControllerBase
{
  private readonly IStorageService _storageService;

  public TeslaApiController(IStorageService storageService)
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
