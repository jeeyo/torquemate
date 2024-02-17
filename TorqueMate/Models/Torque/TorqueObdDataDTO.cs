using Microsoft.AspNetCore.Mvc;

namespace TorqueMate.Models.Torque;

public partial record TorqueDataDTO
{
  /// <summary>
  /// OBD Speed (km/h)
  /// </summary>
  [FromQuery(Name = "kd")]
  public double ObdSpeed { get; init; } = 0;

  /// <summary>
  /// OBD RPM
  /// </summary>
  [FromQuery(Name = "kc")]
  public double ObdRpm { get; init; } = 0;

  /// <summary>
  /// Engine Load (%)
  /// </summary>
  [FromQuery(Name = "k4")]
  public double ObdEngineLoad { get; init; } = 0;

  /// <summary>
  /// OBD Coolant Temperature (°C)
  /// </summary>
  [FromQuery(Name = "k5")]
  public double ObdCoolantTemperature { get; init; } = 0;

  /// <summary>
  /// OBD Battery Voltage (V)
  /// </summary>
  [FromQuery(Name = "kff1238")]
  public double ObdBatteryVoltage { get; init; } = 0;

  /// <summary>
  /// OBD Instananeous CO2 Emission (g/km)
  /// </summary>
  [FromQuery(Name = "kff1257")]
  public double ObdInstananeousCO2Emission { get; init; } = 0;

  /// <summary>
  /// OBD Relative Throttle Position (%)
  /// </summary>
  [FromQuery(Name = "k45")]
  public double ObdRelativeThrottlePosition { get; init; } = 0;

  /// <summary>
  /// OBD Intake Air Temperature (°C)
  /// </summary>
  [FromQuery(Name = "kf")]
  public double ObdIntakeAirTemperature { get; init; } = 0;

  /// <summary>
  /// OBD Trip Distance (km)
  /// </summary>
  [FromQuery(Name = "kff1204")]
  public double ObdTripDistance { get; init; } = 0;

  /// <summary>
  /// OBD Trip Time (s)
  /// </summary>
  [FromQuery(Name = "kff1266")]
  public double ObdTripTime { get; init; } = 0;
}
