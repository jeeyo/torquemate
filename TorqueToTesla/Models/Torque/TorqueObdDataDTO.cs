using Microsoft.AspNetCore.Mvc;

namespace TorqueToTesla.Models.Torque;

public partial record TorqueDataDTO
{
  /// <summary>
  /// OBD Speed (km/h)
  /// </summary>
  [FromQuery(Name = "k0d")]
  public double ObdSpeed { get; init; } = 0;

  /// <summary>
  /// OBD RPM
  /// </summary>
  [FromQuery(Name = "k0c")]
  public double ObdRpm { get; init; } = 0;

  /// <summary>
  /// OBD Coolant Temperature (°C)
  /// </summary>
  [FromQuery(Name = "k05")]
  public double ObdCoolantTemperature { get; init; } = 0;

  /// <summary>
  /// OBD Battery Voltage (V)
  /// </summary>
  [FromQuery(Name = "k2113")]
  public double ObdBatteryVoltage { get; init; } = 0;

  /// <summary>
  /// OBD CO2 Emissions (g/km)
  /// </summary>
  [FromQuery(Name = "kff1257")]
  public double ObdCo2Emissions { get; init; } = 0;

  /// <summary>
  /// OBD Torque (Nm)
  /// </summary>
  [FromQuery(Name = "kff1225")]
  public double ObdTorque { get; init; } = 0;

  /// <summary>
  /// OBD Instantaneous Fuel Consumption (km/l)
  /// </summary>
  [FromQuery(Name = "kff1203")]
  public double ObdInstataneousFuelConsumption { get; init; } = 0;

  /// <summary>
  /// OBD Fuel Level (%)
  /// </summary>
  [FromQuery(Name = "k2f")]
  public double ObdFuelLevelPercentage { get; init; } = 0;
}
