using Microsoft.EntityFrameworkCore;

namespace UygunsuzlukRaporuProjesi.Models
{
    public class UnsuitabilityDbContext : DbContext
    {
        public UnsuitabilityDbContext(DbContextOptions<UnsuitabilityDbContext> options) : base(options)
        {
            
        }
        public DbSet<Unsuitability> Unsuitabilities { get; set; }
    }
}
