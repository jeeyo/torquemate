using Microsoft.Extensions.Caching.Memory;

namespace TorqueToTesla.Services;

public interface IStorageService
{
}

public class StorageService : IStorageService
{
  private readonly IMemoryCache _memoryCache;

  public StorageService(IMemoryCache memoryCache)
  {
    _memoryCache = memoryCache;
  }
}
