using Microsoft.EntityFrameworkCore;

namespace SWApp.Models
{
    public class MvcFilmsContext : DbContext
    {
        public MvcFilmsContext (DbContextOptions<MvcFilmsContext> options)
            : base(options)
        {
        }

        //public DbSet<Films> Films { get; set; }
    }
}