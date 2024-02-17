using Microsoft.AspNetCore.Mvc;

namespace TorqueToToe.Models.Torque;

public partial record TorqueDataDTO
{
  /// <summary>
  /// Acceleration in X-axis (g)
  /// </summary>
  [FromQuery(Name = "kff1220")]
  public double? AccelerationX { get; init; }

  /// <summary>
  /// Acceleration in Y-axis (g)
  /// </summary>
  [FromQuery(Name = "kff1221")]
  public double? AccelerationY { get; init; }

  /// <summary>
  /// Acceleration in Z-axis (g)
  /// </summary>
  [FromQuery(Name = "kff1222")]
  public double? AccelerationZ { get; init; }

  /// <summary>
  /// Acceleration in Total (g)
  /// </summary>
  [FromQuery(Name = "kff1223")]
  public double? AccelerationTotal { get; init; }

  /// <summary>
  /// Relative Throttle Position (%)
  /// </summary>
  [FromQuery(Name = "k45")]
  public double RelativeThrottlePosition { get; init; } = 0;

  /// <summary>
  /// Intake Air Temperature (°C)
  /// </summary>
  [FromQuery(Name = "kf")]
  public double IntakeAirTemperature { get; init; } = 0;

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
