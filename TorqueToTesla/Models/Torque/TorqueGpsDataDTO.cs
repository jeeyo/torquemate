using Microsoft.AspNetCore.Mvc;

namespace TorqueToTesla.Models.Torque;

public partial record TorqueDataDTO
{
  /// <summary>
  /// GPS Speed (km/h)
  /// </summary>
  [FromQuery(Name = "kff1001")]
  public double GpsSpeed { get; init; } = 0;

  /// <summary>
  /// GPS Longitude (degrees)
  /// </summary>
  [FromQuery(Name = "kff1005")]
  public double GpsLongitude { get; init; } = 0;

  /// <summary>
  /// GPS Latitude (degrees)
  /// </summary>
  [FromQuery(Name = "kff1006")]
  public double GpsLatitude { get; init; } = 0;

  /// <summary>
  /// GPS Altitude (m)
  /// </summary>
  [FromQuery(Name = "kff1010")]
  public double GpsAltitude { get; init; } = 0;

  /// <summary>
  /// GPS Heading (degrees)
  /// </summary>
  [FromQuery(Name = "kff123b")]
  public double GpsHeading { get; init; } = 0;

  /// <summary>
  /// GPS Accuracy (m)
  /// </summary>
  [FromQuery(Name = "kff1239")]
  public double GpsAccuracy { get; init; } = 0;
}
