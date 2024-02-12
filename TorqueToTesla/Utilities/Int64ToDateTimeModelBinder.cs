using System.Globalization;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TorqueToTesla.Utilities;

public class Int64ToDateTimeModelBinder : IModelBinder
{
  public Task BindModelAsync(ModelBindingContext bindingContext)
  {
    var value = bindingContext.HttpContext.Request.Query[bindingContext.FieldName];
    var longValue = Convert.ToInt64(value);

    var dateTimeValue = DateTime.UnixEpoch;
    dateTimeValue = dateTimeValue.AddMilliseconds(longValue);

    bindingContext.Result = ModelBindingResult.Success(dateTimeValue);
    return Task.CompletedTask;
  }
}
