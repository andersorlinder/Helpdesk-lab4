using Maintenance_Helpdesk.DbContexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Maintenance_Helpdesk
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
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                                  builder =>
                                  {
                                      builder.WithOrigins("*")
                                                          .AllowAnyHeader()
                                                          .AllowAnyMethod();
                                  });
            });

            //(localdb)\mssqllocaldb
            services.AddControllers();
            services.AddDbContext<Maintenance_HelpdeskDbContext>(options =>
                options.UseSqlServer(
                    @"Server=(localdb)\mssqllocaldb; Database = MaintenanceHelpdesk; Trusted_Connection = True;"
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
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
