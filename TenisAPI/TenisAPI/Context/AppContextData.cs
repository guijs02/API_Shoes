using Microsoft.EntityFrameworkCore;

namespace TenisAPI.Context
{
    public class AppContextData : DbContext
    {
        public AppContextData(DbContextOptions<AppContextData> options) : base(options)
        {
        }
        public DbSet<Shoes> Shoes { get; set; }
    }
}
