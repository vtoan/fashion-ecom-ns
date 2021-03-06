using AutoMapper;
using BUS;
using BUS.Domains;
using Core.Identity;
using Core.Middlewares;
using Core.ServiceExtensions;
using DAO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Core
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddReadConfig(Configuration);
            //Db
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("default")));
            services.AddDefaultIdentity<User>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
            //Reference Service;
            services.AddIdentityServer4();
            services.AddAutoMapper(typeof(MapperConfig).Assembly);

            //My Service
            services.AddBUS();
            services.AddDAO();
            services.AddHelpful();

            //View
            services.AddControllersWithViews()
                    .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
            services.AddRazorPages();
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseGlobalHandlerException();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger(c =>
            {
                c.SerializeAsV2 = true;
            });

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });


            app.UseCors(builder =>
            {
                builder.WithOrigins(ReadConfig.clientUrls["react"], ReadConfig.clientUrls["mvc"])
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .WithExposedHeaders("total-item")
                    .WithHeaders("total-item");
            });

            app.UseStaticFiles();

            app.UseStatusCodePages();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseIdentityServer();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
            });
        }
    }
}
