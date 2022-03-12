using CrimsonLibrary.Data.DataAccess;
using CrimsonLibrary.Data.IReopsitory;
using CrimsonLibrary.Data.Models.DtoProfiles;
using CrimsonLibrary.Data.Repository;
using CrimsonLibrary.Extensions;
using CrimsonLibrary.Services;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace CrimsonLibrary
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
            services.AddControllers().AddNewtonsoftJson(op => 
                    op.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            
            services.AddAuthentication();
            services.ConfigureIdentity();
            services.ConfigureJWT(Configuration);

            services.AddCors(
                x =>
                {
                    x.AddPolicy("AllowAll", builder =>
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader()
                        );
                }
            );
            var name = Configuration["SQLServer:User"];
            var pass = Configuration["SQLServer:Pass"];

            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(Configuration["ConnectionStrings:SqlServer"] + $"user id={name}; password={pass}")
            );


            services.AddAutoMapper(typeof(MapperProfiles));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAuthManager, AuthManager>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CrimsonLibrary", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // general docs
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CrimsonLibrary v1"));

            app.UseHttpsRedirection();

            app.UseCors("AllowAll");
            
            app.UseRouting();

            app.ConfigureExceptionHandler(); // custom exception
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}