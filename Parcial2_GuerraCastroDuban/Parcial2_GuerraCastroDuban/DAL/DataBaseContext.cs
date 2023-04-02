using Microsoft.EntityFrameworkCore;

namespace Parcial2_GuerraCastroDuban.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<Entities.Tickets> Tickets { get; set; }
    }
}
