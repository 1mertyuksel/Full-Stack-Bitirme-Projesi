// Data/DataContext.cs
using Microsoft.EntityFrameworkCore;

namespace PROJEM.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }

        public DbSet<Soru> TümSorular => Set<Soru>();
        public DbSet<SecenekModel> Secenekler => Set<SecenekModel>();
        public DbSet<KullaniciTestSonuc> Sonuc => Set<KullaniciTestSonuc>();
   }
}