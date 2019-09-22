using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MarvelMoviesAPI.Services;

namespace backend
{
    public class Startup
    {
        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = "Server=localhost;Database=MarvelMoviesDB;User Id=sa;Password=Uw12hZxM";

            services.AddDbContext<MarvelMoviesDbContext>(o => o.UseSqlServer(connectionString));

            services.AddMvc();
            services.AddCors();

            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // In production, the React files will be served from this directory. UPDATE THIS FOR Vue.js APPS
            services.AddSpaStaticFiles(configuration =>
            {
               configuration.RootPath = "frontend/build";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, MarvelMoviesDbContext marvelMoviesDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCors(policy => policy
                .AllowAnyHeader()
                .AllowAnyMethod()                    
                .WithOrigins("http://localhost:8080")
                .AllowCredentials());
            }
            //else
            //{
            //    app.UseExceptionHandler("/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            marvelMoviesDbContext.CreateSeedData();

            app.UseMvc();

            app.UseMvc(routes =>
            {
               routes.MapRoute(
                   name: "default",
                   template: "{controller}");
                   //template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "frontend";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "serve");
                }
            });
        }
    }
}