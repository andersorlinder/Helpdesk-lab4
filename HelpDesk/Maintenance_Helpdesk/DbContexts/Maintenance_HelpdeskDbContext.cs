using Maintenance_Helpdesk.Models;
using Microsoft.EntityFrameworkCore;


namespace Maintenance_Helpdesk.DbContexts
{
    public class Maintenance_HelpdeskDbContext : DbContext
    {
        public Maintenance_HelpdeskDbContext(DbContextOptions<Maintenance_HelpdeskDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Maintenance_HelpdeskModel> Maintenance_Helpdesk { get; set; }
    }
}
