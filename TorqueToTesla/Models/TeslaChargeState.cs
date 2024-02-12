using Newtonsoft.Json;

namespace TorqueToTesla.Models;

/// <summary>
/// Tesla Charge State
/// </summary>
/// <remarks>
/// https://developer.tesla.com/docs/fleet-api#vehicle_data
/// </remarks>
public record TeslaChargeState
{
  /// <summary>
  /// Battery Heater On
  /// </summary>
  [JsonProperty("battery_heater_on")]
  public bool BatteryHeaterOn { get; init; } = false;

  /// <summary>
  /// Battery Level (%)
  /// </summary>
  [JsonProperty("battery_level")]
  public int BatteryLevel { get; init; } = 0;

  /// <summary>
  /// Battery Range
  /// </summary>
  [JsonProperty("battery_range")]
  public double BatteryRange { get; init; } = 0;

  /// <summary>
  /// Charge Amps
  /// </summary>
  [JsonProperty("charge_amps")]
  public int ChargeAmps { get; init; } = 0;

  /// <summary>
  /// Charge Current Request
  /// </summary>
  [JsonProperty("charge_current_request")]
  public int ChargeCurrentRequest { get; init; } = 0;

  /// <summary>
  /// Charge Current Request Max
  /// </summary>
  [JsonProperty("charge_current_request_max")]
  public int ChargeCurrentRequestMax { get; init; } = 0;

  /// <summary>
  /// Charge Enable Request
  /// </summary>
  [JsonProperty("charge_enable_request")]
  public bool ChargeEnableRequest { get; init; } = false;

  /// <summary>
  /// Charge Energy Added
  /// </summary>
  [JsonProperty("charge_energy_added")]
  public double ChargeEnergyAdded { get; init; } = 0;

  /// <summary>
  /// Charge Limit State of Charge
  /// </summary>
  [JsonProperty("charge_limit_soc")]
  public int ChargeLimitSoc { get; init; } = 0;

  /// <summary>
  /// Charge Limit State of Charge Max
  /// </summary>
  [JsonProperty("charge_limit_soc_max")]
  public int ChargeLimitSocMax { get; init; } = 0;

  /// <summary>
  /// Charge Limit State of Charge Min
  /// </summary>
  [JsonProperty("charge_limit_soc_min")]
  public int ChargeLimitSocMin { get; init; } = 0;

  /// <summary>
  /// Charge Limit State of Charge Standard
  /// </summary>
  [JsonProperty("charge_limit_soc_std")]
  public int ChargeLimitSocStd { get; init; } = 0;

  /// <summary>
  /// Charge Miles Added Ideal
  /// </summary>
  [JsonProperty("charge_miles_added_ideal")]
  public int ChargeMilesAddedIdeal { get; init; } = 0;

  /// <summary>
  /// Charge Miles Added Rated
  /// </summary>
  [JsonProperty("charge_miles_added_rated")]
  public int ChargeMilesAddedRated { get; init; } = 0;

  /// <summary>
  /// Charge Port Cold Weather Mode
  /// </summary>
  [JsonProperty("charge_port_cold_weather_mode")]
  public bool ChargePortColdWeatherMode { get; init; } = false;

  /// <summary>
  /// Charge Port Color
  /// </summary>
  [JsonProperty("charge_port_color")]
  public string ChargePortColor { get; init; } = "<invalid>";

  /// <summary>
  /// Charge Port Door Open
  /// </summary>
  [JsonProperty("charge_port_door_open")]
  public bool ChargePortDoorOpen { get; init; } = false;

  /// <summary>
  /// Charge Port Latch
  /// </summary>
  [JsonProperty("charge_port_latch")]
  public string ChargePortLatch { get; init; } = "Engaged";

  /// <summary>
  /// Charge Rate
  /// </summary>
  [JsonProperty("charge_rate")]
  public int ChargeRate { get; init; } = 0;

  /// <summary>
  /// Charger Actual Current
  /// </summary>
  [JsonProperty("charger_actual_current")]
  public int ChargerActualCurrent { get; init; } = 0;

  /// <summary>
  /// Charger Phases
  /// </summary>
  [JsonProperty("charger_phases")]
  public int? ChargerPhases { get; init; } = null;

  /// <summary>
  /// Charger Pilot Current
  /// </summary>
  [JsonProperty("charger_pilot_current")]
  public int ChargerPilotCurrent { get; init; } = 0;

  /// <summary>
  /// Charger Power
  /// </summary>
  [JsonProperty("charger_power")]
  public int ChargerPower { get; init; } = 0;

  /// <summary>
  /// Charger Voltage
  /// </summary>
  [JsonProperty("charger_voltage")]
  public int ChargerVoltage { get; init; } = 0;

  /// <summary>
  /// Charging State
  /// </summary>
  [JsonProperty("charging_state")]
  public string ChargingState { get; init; } = "Disconnected";

  /// <summary>
  /// Connection Charge Cable
  /// </summary>
  [JsonProperty("conn_charge_cable")]
  public string ConnChargeCable { get; init; } = "<invalid>";

  /// <summary>
  /// Estimated Battery Range
  /// </summary>
  [JsonProperty("est_battery_range")]
  public double EstimatedBatteryRange { get; init; } = 0;

  /// <summary>
  /// Fast Charger Brand
  /// </summary>
  [JsonProperty("fast_charger_brand")]
  public string FastChargerBrand { get; init; } = "<invalid>";

  /// <summary>
  /// Fast Charger Present
  /// </summary>
  [JsonProperty("fast_charger_present")]
  public bool FastChargerPresent { get; init; } = false;

  /// <summary>
  /// Fast Charger Type
  /// </summary>
  [JsonProperty("fast_charger_type")]
  public string FastChargerType { get; init; } = "<invalid>";

  /// <summary>
  /// Ideal Battery Range
  /// </summary>
  [JsonProperty("ideal_battery_range")]
  public double IdealBatteryRange { get; init; } = 0;

  /// <summary>
  /// Managed Charging Active
  /// </summary>
  [JsonProperty("managed_charging_active")]
  public bool ManagedChargingActive { get; init; } = false;

  /// <summary>
  /// Managed Charging Start Time
  /// </summary>
  [JsonProperty("managed_charging_start_time")]
  public int? ManagedChargingStartTime { get; init; } = null;

  /// <summary>
  /// Managed Charging User Canceled
  /// </summary>
  [JsonProperty("managed_charging_user_canceled")]
  public bool ManagedChargingUserCanceled { get; init; } = false;

  /// <summary>
  /// Maximum Range Charge Counter
  /// </summary>
  [JsonProperty("max_range_charge_counter")]
  public int MaxRangeChargeCounter { get; init; } = 0;

  /// <summary>
  /// Minutes to Full Charge
  /// </summary>
  [JsonProperty("minutes_to_full_charge")]
  public int MinutesToFullCharge { get; init; } = 0;

  /// <summary>
  /// Not Enough Power to Heat
  /// </summary>
  [JsonProperty("not_enough_power_to_heat")]
  public bool? NotEnoughPowerToHeat { get; init; } = null;

  /// <summary>
  /// Off Peak Charging Enabled
  /// </summary>
  [JsonProperty("off_peak_charging_enabled")]
  public bool OffPeakChargingEnabled { get; init; } = false;

  /// <summary>
  /// Off Peak Charging Times
  /// </summary>
  [JsonProperty("off_peak_charging_times")]
  public string OffPeakChargingTimes { get; init; } = "all_week";

  /// <summary>
  /// Off Peak Hours End Time
  /// </summary>
  [JsonProperty("off_peak_hours_end_time")]
  public int OffPeakHoursEndTime { get; init; } = 0;

  /// <summary>
  /// Preconditioning Enabled
  /// </summary>
  [JsonProperty("preconditioning_enabled")]
  public bool PreconditioningEnabled { get; init; } = false;

  /// <summary>
  /// Preconditioning Times
  /// </summary>
  [JsonProperty("preconditioning_times")]
  public string PreconditioningTimes { get; init; } = "all_week";

  /// <summary>
  /// Scheduled Charging Mode
  /// </summary>
  [JsonProperty("scheduled_charging_mode")]
  public string ScheduledChargingMode { get; init; } = "Off";

  /// <summary>
  /// Scheduled Charging Pending
  /// </summary>
  [JsonProperty("scheduled_charging_pending")]
  public bool ScheduledChargingPending { get; init; } = false;

  /// <summary>
  /// Scheduled Charging Start Time
  /// </summary>
  [JsonProperty("scheduled_charging_start_time")]
  public int? ScheduledChargingStartTime { get; init; } = null;

  /// <summary>
  /// Scheduled Departure Time
  /// </summary>
  [JsonProperty("scheduled_departure_time")]
  public int ScheduledDepartureTime { get; init; } = 0;

  /// <summary>
  /// Scheduled Departure Time Minutes
  /// </summary>
  [JsonProperty("scheduled_departure_time_minutes")]
  public int ScheduledDepartureTimeMinutes { get; init; } = 0;

  /// <summary>
  /// Supercharger Session Trip Planner
  /// </summary>
  [JsonProperty("supercharger_session_trip_planner")]
  public bool SuperchargerSessionTripPlanner { get; init; } = false;

  /// <summary>
  /// Time to Full Charge
  /// </summary>
  [JsonProperty("time_to_full_charge")]
  public int TimeToFullCharge { get; init; } = 0;

  /// <summary>
  /// Timestamp (ms)
  /// </summary>
  [JsonProperty("timestamp")]
  public long Timestamp { get; init; } = 0;

  /// <summary>
  /// Trip Charging
  /// </summary>
  [JsonProperty("trip_charging")]
  public bool TripCharging { get; init; } = false;

  /// <summary>
  /// Usable Battery Level (%)
  /// </summary>
  [JsonProperty("usable_battery_level")]
  public int UsableBatteryLevel { get; init; } = 0;

  /// <summary>
  /// User Charge Enable Request
  /// </summary>
  [JsonProperty("user_charge_enable_request")]
  public bool? UserChargeEnableRequest { get; init; } = null;
}
