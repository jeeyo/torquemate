using Newtonsoft.Json;

namespace TorqueToTesla.Models.Tesla;

/// <summary>
/// Tesla Climate State
/// </summary>
/// <remarks>
/// https://developer.tesla.com/docs/fleet-api#vehicle_data
/// </remarks>
public record TeslaClimateState
{
  /// <summary>
  /// Allow Cabin Overheat Protection
  /// </summary>
  [JsonProperty("allow_cabin_overheat_protection")]
  public bool AllowCabinOverheatProtection { get; init; } = false;

  /// <summary>
  /// Auto Seat Climate Left
  /// </summary>
  [JsonProperty("auto_seat_climate_left")]
  public bool AutoSeatClimateLeft { get; init; } = false;

  /// <summary>
  /// Auto Seat Climate Right
  /// </summary>
  [JsonProperty("auto_seat_climate_right")]
  public bool AutoSeatClimateRight { get; init; } = false;

  /// <summary>
  /// Auto Steering Wheel Heat
  /// </summary>
  [JsonProperty("auto_steering_wheel_heat")]
  public bool AutoSteeringWheelHeat { get; init; } = false;

  /// <summary>
  /// Battery Heater
  /// </summary>
  [JsonProperty("battery_heater")]
  public bool BatteryHeater { get; init; } = false;

  /// <summary>
  /// Battery Heater No Power
  /// </summary>
  [JsonProperty("battery_heater_no_power")]
  public bool? BatteryHeaterNoPower { get; init; } = null;

  /// <summary>
  /// Bioweapon Mode
  /// </summary>
  [JsonProperty("bioweapon_mode")]
  public bool BioweaponMode { get; init; } = false;

  /// <summary>
  /// Cabin Overheat Protection
  /// </summary>
  [JsonProperty("cabin_overheat_protection")]
  public string CabinOverheatProtection { get; init; } = "Off";

  /// <summary>
  /// Cabin Overheat Protection Actively Cooling
  /// </summary>
  [JsonProperty("cabin_overheat_protection_actively_cooling")]
  public bool CabinOverheatProtectionActivelyCooling { get; init; } = false;

  /// <summary>
  /// Climate Keeper Mode
  /// </summary>
  [JsonProperty("climate_keeper_mode")]
  public string ClimateKeeperMode { get; init; } = "off";

  /// <summary>
  /// Cabin Overheat Protection Activation Temperature
  /// </summary>
  [JsonProperty("cop_activation_temperature")]
  public string CopActivationTemperature { get; init; } = "Low";

  /// <summary>
  /// Defrost Mode
  /// </summary>
  [JsonProperty("defrost_mode")]
  public int DefrostMode { get; init; } = 0;

  /// <summary>
  /// Driver Temp Setting (°C)
  /// </summary>
  [JsonProperty("driver_temp_setting")]
  public double DriverTempSetting { get; init; } = 0;

  /// <summary>
  /// Fan Status
  /// </summary>
  [JsonProperty("fan_status")]
  public int FanStatus { get; init; } = 0;

  /// <summary>
  /// HVAC Auto Request
  /// </summary>
  [JsonProperty("hvac_auto_request")]
  public string HvacAutoRequest { get; init; } = "Off";

  /// <summary>
  /// Inside Temp (°C)
  /// </summary>
  [JsonProperty("inside_temp")]
  public double InsideTemp { get; init; } = 0;

  /// <summary>
  /// Is Auto Conditioning On
  /// </summary>
  [JsonProperty("is_auto_conditioning_on")]
  public bool IsAutoConditioningOn { get; init; } = false;

  /// <summary>
  /// Is Climate On
  /// </summary>
  [JsonProperty("is_climate_on")]
  public bool IsClimateOn { get; init; } = false;

  /// <summary>
  /// Is Front Defroster On
  /// </summary>
  [JsonProperty("is_front_defroster_on")]
  public bool IsFrontDefrosterOn { get; init; } = false;

  /// <summary>
  /// Is Preconditioning
  /// </summary>
  [JsonProperty("is_preconditioning")]
  public bool IsPreconditioning { get; init; } = false;

  /// <summary>
  /// Is Rear Defroster On
  /// </summary>
  [JsonProperty("is_rear_defroster_on")]
  public bool IsRearDefrosterOn { get; init; } = false;

  /// <summary>
  /// Left Temp Direction
  /// </summary>
  [JsonProperty("left_temp_direction")]
  public int LeftTempDirection { get; init; } = 0;

  /// <summary>
  /// Max Avail Temp (°C)
  /// </summary>
  [JsonProperty("max_avail_temp")]
  public int MaxAvailTemp { get; init; } = 0;

  /// <summary>
  /// Min Avail Temp (°C)
  /// </summary>
  [JsonProperty("min_avail_temp")]
  public int MinAvailTemp { get; init; } = 0;

  /// <summary>
  /// Outside Temp (°C)
  /// </summary>
  [JsonProperty("outside_temp")]
  public double OutsideTemp { get; init; } = 0;

  /// <summary>
  /// Passenger Temp Setting (°C)
  /// </summary>
  [JsonProperty("passenger_temp_setting")]
  public double PassengerTempSetting { get; init; } = 0;

  /// <summary>
  /// Remote Heater Control Enabled
  /// </summary>
  [JsonProperty("remote_heater_control_enabled")]
  public bool RemoteHeaterControlEnabled { get; init; } = false;

  /// <summary>
  /// Right Temp Direction
  /// </summary>
  [JsonProperty("right_temp_direction")]
  public int RightTempDirection { get; init; } = 0;

  /// <summary>
  /// Seat Heater Left
  /// </summary>
  [JsonProperty("seat_heater_left")]
  public int SeatHeaterLeft { get; init; } = 0;

  /// <summary>
  /// Seat Heater Rear Center
  /// </summary>
  [JsonProperty("seat_heater_rear_center")]
  public int SeatHeaterRearCenter { get; init; } = 0;

  /// <summary>
  /// Seat Heater Rear Left
  /// </summary>
  [JsonProperty("seat_heater_rear_left")]
  public int SeatHeaterRearLeft { get; init; } = 0;

  /// <summary>
  /// Seat Heater Rear Right
  /// </summary>
  [JsonProperty("seat_heater_rear_right")]
  public int SeatHeaterRearRight { get; init; } = 0;

  /// <summary>
  /// Seat Heater Right
  /// </summary>
  [JsonProperty("seat_heater_right")]
  public int SeatHeaterRight { get; init; } = 0;

  /// <summary>
  /// Side Mirror Heaters
  /// </summary>
  [JsonProperty("side_mirror_heaters")]
  public bool SideMirrorHeaters { get; init; } = false;

  /// <summary>
  /// Steering Wheel Heat Level
  /// </summary>
  [JsonProperty("steering_wheel_heat_level")]
  public int SteeringWheelHeatLevel { get; init; } = 0;

  /// <summary>
  /// Steering Wheel Heater
  /// </summary>
  [JsonProperty("steering_wheel_heater")]
  public bool SteeringWheelHeater { get; init; } = false;

  /// <summary>
  /// Supports Fan Only Cabin Overheat Protection
  /// </summary>
  [JsonProperty("supports_fan_only_cabin_overheat_protection")]
  public bool SupportsFanOnlyCabinOverheatProtection { get; init; } = false;

  /// <summary>
  /// Timestamp (ms)
  /// </summary>
  [JsonProperty("timestamp")]
  public long Timestamp { get; init; } = 0;

  /// <summary>
  /// Wiper Blade Heater
  /// </summary>
  [JsonProperty("wiper_blade_heater")]
  public bool WiperBladeHeater { get; init; } = false;
}
