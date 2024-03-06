using Microsoft.AspNetCore.Mvc;
using TorqueMate.Utilities;

namespace TorqueMate.Models.Torque;

/// <summary>
/// Data Transfer Object for Torque data
/// </summary>
/// <remarks>
/// https://github.com/briancline/torque-satellite/blob/master/doc/codes-table.md
/// </remarks>
public partial record TorqueDataDTO
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
}
