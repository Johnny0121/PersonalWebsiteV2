using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Stripe;

namespace PersonalWebsiteV2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            __Configuration = configuration;
        }

        public IConfiguration __Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                StripeConfiguration.ApiKey = "sk_test_51Ha85VCBa5lwqRr4ZzDXnYiswkg7PAb9Rv3MbZCIhFvkpWPKYlEOgMm2JL7qfasPfWBUO51m0gwqbGsym8u91txV00CZhWwEvR";

                app.UseDeveloperExceptionPage();
            }
            else
            {
                StripeConfiguration.ApiKey = __Configuration["STRIPE_SECRET_KEY"];

                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
