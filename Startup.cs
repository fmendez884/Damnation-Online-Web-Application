using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Damnation_Online_Web_Application
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
            services.AddControllersWithViews();

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            var provider = new FileExtensionContentTypeProvider();
            provider.Mappings[".unityweb"] = "application/octet-stream";
            provider.Mappings[".js"] = "application/javascript";
            provider.Mappings[".js.gz"] = "application/javascript";
            provider.Mappings[".js.br"] = "application/javascript";
            provider.Mappings[".wasm"] = "application/wasm";
            provider.Mappings[".wasm.gz"] = "application/wasm";
            provider.Mappings[".wasm.br"] = "application/wasm";
            provider.Mappings[".gz"] = "gzip";
            provider.Mappings[".br"] = "br";
            provider.Mappings.Remove(".unityweb");
            provider.Mappings.Add(".unityweb", "application/octet-stream");
            //provider.Mappings.Remove(".data");
            //provider.Mappings.Add(".data", "application/octet-stream");
            provider.Mappings.Remove(".wasm");
            provider.Mappings.Add(".wasm", "application/wasm");
            //provider.Mappings.Remove(".symbols.json");
            //provider.Mappings.Add(".symbols.json", "application/octet-stream");
            //provider.Mappings.Remove(".js.br");
            //provider.Mappings.Add(".js.br", "application/javascript");
            provider.Mappings.Remove(".js");
            provider.Mappings.Add(".js", "application/javascript");
            provider.Mappings.Remove(".framework.js");
            provider.Mappings.Add(".framework.js", "application/javascript");
            provider.Mappings.Remove(".gz");
            provider.Mappings.Add(".gz", "application/octet-stream");
            //provider.Mappings.Remove(".js.gz");
            //provider.Mappings.Add(".js.gz", "application/javascript");
            //provider.Mappings.Remove(".br");
            //provider.Mappings.Add(".br", "application/octet-stream");


            app.UseStaticFiles(new StaticFileOptions
            {
                ContentTypeProvider = provider
            });

            //app.UseStaticFiles();
            app.UseSpaStaticFiles(new StaticFileOptions
            {
                ContentTypeProvider = provider
            });

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
