using CrimsonLibrary.Data.DataAccess;
using CrimsonLibrary.Data.Errors;
using CrimsonLibrary.Data.Models;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

using Serilog;

using System.Text;

namespace CrimsonLibrary.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentityCore<ApiUser>(q => {
                q.User.RequireUniqueEmail = true;
            });
            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), services);
            builder.AddEntityFrameworkStores<DatabaseContext>().AddDefaultTokenProviders();
        }

        public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtSettings = configuration["Jwt"];
            var jwtKey = configuration["JWTKey"];

            services.AddAuthentication(opt => {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(opt =>
                {
                    opt.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = configuration["Jwt:Issuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey))
                    };
                })
                ;
        }


        public static void ConfigureExceptionHandler( this IApplicationBuilder builder)
        {
            builder.UseExceptionHandler(error =>
           {
               error.Run(async context =>
               {
                   context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                   context.Response.ContentType = "application/json";
                   var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                   if (contextFeature != null)
                   {
                       Log.Error($"Something went wrong in {contextFeature.Error}");

                       await context.Response.WriteAsync(new Error
                       {
                           StatusCode = context.Response.StatusCode, 
                           Message = "Internal server error, please try again later~!"
                       }.ToString());
                   }
               });
           });
        }
    }
}
