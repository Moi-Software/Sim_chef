using Microsoft.EntityFrameworkCore;
using simchef.Models;

namespace simchef.DataAcess
{
  public class ConectionContest : DbContext
  {
    public DbSet<Produtos> produtos { get; set; }
    public DbSet<UrlNota> urlNotas { get; set; }
    public ConectionContest(DbContextOptions<ConectionContest> options)
    : base(options)
    {
        
    }
  }
}