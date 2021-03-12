using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineRetailApp.Repository;
using OnlineRetailApp.Repository.Implementation;
using OnlineRetailApp.Repository.Interface;
using OnlineRetailApp.Services.Implementation;
using OnlineRetailApp.Services.Interface;
/*using Microsoft.OpenApi.Models;*/

namespace onlineRetailApp.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

           /* services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = " API", Version = "v1" });
            });*/

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddDbContext<AppDbContext>(appDbContext=> appDbContext.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), sql =>
            {
                sql.EnableRetryOnFailure(5);
                sql.CommandTimeout(60);
                sql.MigrationsAssembly("OnlineRetailApp.Repository");
            }));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

           /* app.UseSwagger(c =>
            {
            });*/

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
