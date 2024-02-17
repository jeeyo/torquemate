using Npgsql;
using NpgsqlTypes;
using Serilog;
using TorqueToToe.Models.Torque;
using ILogger = Serilog.ILogger;

namespace TorqueToToe.Services;

public interface ITorqueStorageService
{
  Task<bool> StoreTorqueData(TorqueDataDTO torqueData);
}

public class TorqueStorageService : ITorqueStorageService, IDisposable
{
  private readonly NpgsqlDataSource _npgsqlDataSource;
  private readonly ILogger _logger = Log.ForContext<TorqueStorageService>();

  public TorqueStorageService(NpgsqlDataSource npgsqlDataSource)
  {
    _npgsqlDataSource = npgsqlDataSource;
  }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public async Task<bool> StoreTorqueData(TorqueDataDTO torqueData)
    {
      await using var connection = await _npgsqlDataSource.OpenConnectionAsync();
      await using var cmd = _npgsqlDataSource.CreateCommand(@"
      INSERT INTO torque_data (
        device_id,
        session_id,
        time,
        gps_latitude,
        gps_longitude,
        gps_speed,
        gps_altitude,
        gps_heading,
        gps_accuracy,
        gps_satellites,
        obd_speed,
        obd_rpm,
        obd_engine_load,
        obd_coolant_temperature,
        obd_battery_voltage,
        obd_instananeous_co2_emission,
        obd_relative_throttle_position,
        obd_intake_air_temperature,
        obd_trip_distance,
        obd_trip_time
      ) VALUES (
        @device_id,
        @session_id,
        @time,
        @gps_latitude,
        @gps_longitude,
        @gps_speed,
        @gps_altitude,
        @gps_heading,
        @gps_accuracy,
        @gps_satellites,
        @obd_speed,
        @obd_rpm,
        @obd_engine_load,
        @obd_coolant_temperature,
        @obd_battery_voltage,
        @obd_instananeous_co2_emission,
        @obd_relative_throttle_position,
        @obd_intake_air_temperature,
        @obd_trip_distance,
        @obd_trip_time
      )");

      cmd.Parameters.AddWithValue("device_id", torqueData.DeviceId);
      cmd.Parameters.AddWithValue("session_id", torqueData.SessionId);
      cmd.Parameters.AddWithValue("time", torqueData.Time);
      cmd.Parameters.AddWithValue("gps_latitude", new NpgsqlPoint(torqueData.GpsLatitude[0], torqueData.GpsLatitude[1]));
      cmd.Parameters.AddWithValue("gps_longitude", new NpgsqlPoint(torqueData.GpsLongitude[0], torqueData.GpsLongitude[1]));
      cmd.Parameters.AddWithValue("gps_speed", torqueData.GpsSpeed);
      cmd.Parameters.AddWithValue("gps_altitude", torqueData.GpsAltitude);
      cmd.Parameters.AddWithValue("gps_heading", torqueData.GpsHeading);
      cmd.Parameters.AddWithValue("gps_accuracy", torqueData.GpsAccuracy);
      cmd.Parameters.AddWithValue("gps_satellites", torqueData.GpsSatellites);
      cmd.Parameters.AddWithValue("obd_speed", torqueData.ObdSpeed);
      cmd.Parameters.AddWithValue("obd_rpm", torqueData.ObdRpm);
      cmd.Parameters.AddWithValue("obd_engine_load", torqueData.ObdEngineLoad);
      cmd.Parameters.AddWithValue("obd_coolant_temperature", torqueData.ObdCoolantTemperature);
      cmd.Parameters.AddWithValue("obd_battery_voltage", torqueData.ObdBatteryVoltage);
      cmd.Parameters.AddWithValue("obd_instananeous_co2_emission", torqueData.ObdInstananeousCO2Emission);
      cmd.Parameters.AddWithValue("obd_relative_throttle_position", torqueData.ObdRelativeThrottlePosition);
      cmd.Parameters.AddWithValue("obd_intake_air_temperature", torqueData.ObdIntakeAirTemperature);
      cmd.Parameters.AddWithValue("obd_trip_distance", torqueData.ObdTripDistance);
      cmd.Parameters.AddWithValue("obd_trip_time", torqueData.ObdTripTime);

      var result = await cmd.ExecuteNonQueryAsync();
      return result > 0;
    }
}
