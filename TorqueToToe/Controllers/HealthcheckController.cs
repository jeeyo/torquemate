using Microsoft.AspNetCore.Mvc;
using TorqueToToe.Services;

namespace TorqueToToe;

[ApiController]
public class HealthcheckController : ControllerBase
{
  /// <summary>
  /// Returns 200 OK
  /// </summary>
  /// <response code="200">Returns 200 OK</response>
  [HttpGet("healthcheck")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  public ActionResult Healthcheck()
  {
    return Ok();
  }
}
