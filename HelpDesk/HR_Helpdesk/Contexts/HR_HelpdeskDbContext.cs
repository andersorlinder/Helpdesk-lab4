using HR_Helpdesk.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Helpdesk.Context
{
    public class HR_HelpdeskDbContext:DbContext
    {
        public HR_HelpdeskDbContext(DbContextOptions<HR_HelpdeskDbContext> options)
            :base(options)
        {
        }

        public DbSet<HR_HelpdeskModel> HR_Helpdesk { get; set; }
    }
}
