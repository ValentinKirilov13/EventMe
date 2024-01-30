using EventMe.Data.Data.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace EventMe.Data.Data
{
    public class EventMeDbContext : DbContext
    {
        public EventMeDbContext(DbContextOptions<EventMeDbContext> options)
            : base(options) { }

        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
