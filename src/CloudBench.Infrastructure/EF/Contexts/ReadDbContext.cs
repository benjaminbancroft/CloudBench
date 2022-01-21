using Microsoft.EntityFrameworkCore;

namespace CloudBench.Infrastructure.EF.Contexts;

internal class ReadDbContext : DbContext
{
  public ReadDbContext(DbContextOptions<ReadDbContext> options)
    : base(options)
  {
  }
}