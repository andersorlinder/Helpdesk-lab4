using IT_Helpdesk.Models;
using Microsoft.EntityFrameworkCore;

namespace IT_Helpdesk.DbContexts
{
    public class IT_HelpdeskDbContext : DbContext
    {
        public IT_HelpdeskDbContext(DbContextOptions<IT_HelpdeskDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<IT_HelpdeskModel> IT_Helpdesk { get; set; }
    }
}