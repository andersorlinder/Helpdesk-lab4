using IT_Helpdesk.DbContexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace IT_Helpdesk
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //services.AddDbContext<IT_HelpdeskDbContext>(options =>
            //    options.UseSqlServer(
            //        @"Server=(localdb)\MSSQLLocalDB; Database = ITHelpdeskDb; Trusted_Connection = True;"
            //        )
            services.AddDbContext<IT_HelpdeskDbContext>(options =>
                options.UseSqlite(
                    @"Filename=Database/IT_Helpdesk_Db.db"
                    )
            );
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}