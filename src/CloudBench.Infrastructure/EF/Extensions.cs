using CloudBench.Infrastructure.EF.Contexts;
using CloudBench.Infrastructure.EF.Options;
using CloudBench.Shared.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CloudBench.Infrastructure.EF;

internal static class Extensions
{
  public static IServiceCollection AddSql(this IServiceCollection services, IConfiguration configuration)
  {
    var dbOptions = configuration.GetOptions<DatabaseOptions>("Database");
    services.AddDbContext<ReadDbContext>(c => c.UseSqlServer(dbOptions.ConnectionString));
    return services;
  }
}