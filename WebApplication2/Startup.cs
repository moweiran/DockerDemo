using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebApplication2.Models;

namespace WebApplication2
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
            var connectionString = Configuration.GetConnectionString("DBConnection");
            services.AddDbContextPool<TXWDBContext>(options =>
            {
                options.UseSqlServer(connectionString, db => db.UseRowNumberForPaging());
            });
            services.AddCustomCors();
            services.AddHttpContextAccessor();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHttpContextAccessor httpContextAccessor, IHostingEnvironment env)
        {
            app.UseMiddleware<CorsOptionResponse>();
            app.UseCors("AllowAllOrigin");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseHsts();
            }
            //app.UseHttpsRedirection();
            app.UseMvc(options =>
            {
                options.MapRoute(
                       name: "default",
                       template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
    public static class CustomConfiguration
    {
        public static IServiceCollection AddCustomCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigin", builders =>
                {
                    builders
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials()
                        .AllowAnyOrigin();
                });
            });
            return services;
        }
    }
    public class CorsOptionResponse
    {
        //解决net::ERR_INVALID_HTTP_RESPONSE
        //https://github.com/aspnet/AspNetCore/issues/4398
        //https://stackoverflow.com/questions/53906866/neterr-invalid-http-response-error-after-post-request-with-angular-7

        private readonly RequestDelegate _next;
        public CorsOptionResponse(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next(context);
            if (context.Response.StatusCode == 204)
            {
                context.Response.ContentLength = 0;
            }
        }
    }
}
