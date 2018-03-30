using Friendly.Models;
using Microsoft.EntityFrameworkCore;

namespace Friendly.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    public DbSet<Photo> Photos { get; set; }
    public DbSet<Value> Values { get; set; }
    public DbSet<User> Users { get; set; }
    
  }
}
