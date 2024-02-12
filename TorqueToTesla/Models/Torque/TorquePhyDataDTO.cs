using Microsoft.AspNetCore.Mvc;

namespace TorqueToTesla.Models.Torque;

public partial record TorqueDataDTO
{
  /// <summary>
  /// Acceleration in X-axis (m/s^2)
  /// </summary>
  [FromQuery(Name = "kff1220")]
  public double AccelerationX { get; init; } = 0;

  /// <summary>
  /// Acceleration in Y-axis (m/s^2)
  /// </summary>
  [FromQuery(Name = "kff1221")]
  public double AccelerationY { get; init; } = 0;

  /// <summary>
  /// Acceleration in Z-axis (m/s^2)
  /// </summary>
  [FromQuery(Name = "kff1222")]
  public double AccelerationZ { get; init; } = 0;

  /// <summary>
  /// Acceleration in Total (m/s^2)
  /// </summary>
  [FromQuery(Name = "kff1223")]
  public double AccelerationTotal { get; init; } = 0;

  /// <summary>
  /// Ambient Temperature (°C)
  /// </summary>
  [FromQuery(Name = "k46")]
  public double AmbientTemp { get; init; } = 0;

  /// <summary>
  /// Barometric Pressure (kPa)
  /// </summary>
  [FromQuery(Name = "k33")]
  public double BarometricPressure { get; init; } = 0;
}
