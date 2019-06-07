using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncyklopediaZwierzat.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EncyklopediaZwierzat
{
    public class Startup
    {
        public IConfiguration Configuration { get; } //21
        public Startup(IConfiguration configuration) //22
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));//19 i 23 odwolanei sie do cinfiguracji by poprosic o ciag poalczenia
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>(); //domyslna konfiguracja systemu tozsamosci
            services.AddTransient<IZwierzeRepository, ZwierzeRepository>(); // za kazdym razem gdy żadana bedzie instancja IZwierzeRepo to zostanie zwrócone MockZwierzeRepo //7 //24 mock na docelowe repo
            services.AddTransient<IOpiniaRepository, OpiniaRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseAuthentication(); // posredniczace oprog. sluzy do uwierzytelniania
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "Default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
