using HR_Helpdesk.Models;
using Microsoft.EntityFrameworkCore;

namespace HR_Helpdesk.DBContexts
{
    public class HR_HelpdeskDbContext:DbContext
    {
        public HR_HelpdeskDbContext(DbContextOptions<HR_HelpdeskDbContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<HR_HelpdeskModel> HR_Helpdesk { get; set; }
    }
}
