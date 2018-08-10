using JsonApiDotNetCore.Extensions;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebAPI.Models;

namespace WebAPI
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
            var mvcBuilder = services.AddMvcCore()
                                     .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddJsonApi(options => {
                options.Namespace = "api/v1";
                options.BuildContextGraph((builder) => {
                    builder.AddResource<Listing>("listings");
                    builder.AddResource<Agent>("agents");
                    builder.AddResource<Office>("offices");
                    builder.AddResource<Location>("locations");
                });
            }, mvcBuilder);

            services.AddScoped<IResourceService<Listing>, ListingService>();

            services.BuildServiceProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
