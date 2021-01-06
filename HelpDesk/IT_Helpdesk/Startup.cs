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

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var fullPath = Environment.CurrentDirectory;
            services.AddControllers();
            //services.AddDbContext<IT_HelpdeskDbContext>(options =>
            //    options.UseSqlServer(
            //        @"Server=localhost; Database = ITHelpdeskDb; Trusted_Connection = True;"
            //        )
            services.AddDbContext<IT_HelpdeskDbContext>(options =>
                options.UseSqlite(
                    @"Data Source=(localdb)\MSSQLLocalDB;Filename=IT_Helpdesk.db"
                    )
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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