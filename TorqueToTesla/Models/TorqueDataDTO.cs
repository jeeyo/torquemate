using Microsoft.AspNetCore.Mvc;
using TorqueToTesla.Utilities;

namespace TorqueToTesla.Models;

/// <summary>
/// Data Transfer Object for Torque data
/// </summary>
/// <remarks>
/// https://github.com/briancline/torque-satellite/blob/master/doc/codes-table.md
/// </remarks>
public record TorqueDataDTO
{
  /// <summary>
  /// Email Address
  /// (doesn't have to be in email syntax)
  /// </summary>
  [FromQuery(Name="eml")]
  public string Email { get; init; } = "";

  /// <summary>
  /// Device ID
  /// </summary>
  [FromQuery(Name = "id")]
  public string DeviceId { get; init; } = "";

  /// <summary>
  /// Session ID
  /// </summary>
  [FromQuery(Name = "session")]
  public string SessionId { get; init; } = "";

  /// <summary>
  /// Unix timestamp (ms)
  /// </summary>
  [FromQuery(Name = "time")]
  [ModelBinder(BinderType = typeof(Int64ToDateTimeModelBinder))]
  public DateTime Time { get; init; } = DateTime.UtcNow;

  /// <summary>
  /// Longitude (degrees)
  /// </summary>
  [FromQuery(Name = "kff1005")]
  public double Longitude { get; init; } = 0;

  /// <summary>
  /// Latitude (degrees)
  /// </summary>
  [FromQuery(Name = "kff1006")]
  public double Latitude { get; init; } = 0;

  /// <summary>
  /// Barometric Pressure (kPa)
  /// </summary>
  [FromQuery(Name = "k33")]
  public double BarometricPressure { get; init; } = 0;
}
