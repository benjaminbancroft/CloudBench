using Microsoft.Extensions.Configuration;

namespace CloudBench.Shared.Options;

public static class Extensions
{
  public static T GetOptions<T>(this IConfiguration config, string sectionName)
    where T : new()
  {
    var options = new T();
    config.GetSection(sectionName).Bind(options);
    return options;
  }
}