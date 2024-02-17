using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TorqueToToe.Utilities;

public class Int64ToDateTimeModelBinder : IModelBinder
{
  public Task BindModelAsync(ModelBindingContext bindingContext)
  {
    var value = bindingContext.HttpContext.Request.Query[bindingContext.FieldName];

    var dateTimeValue = DateTime.UnixEpoch;

    var success = long.TryParse(value, out var longValue);
    if (success) dateTimeValue = dateTimeValue.AddMilliseconds(longValue);
    else dateTimeValue = DateTime.Now;

    bindingContext.Result = ModelBindingResult.Success(dateTimeValue);
    return Task.CompletedTask;
  }
}
