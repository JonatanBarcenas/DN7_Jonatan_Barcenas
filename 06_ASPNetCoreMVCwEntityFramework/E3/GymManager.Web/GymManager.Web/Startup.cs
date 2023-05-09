using GymManager.AplicationServices.Equipment;
using GymManager.AplicationServices.Equipments;
using GymManager.AplicationServices.Members;
using GymManager.AplicationServices.Navigation;
using GymManager.Core.Equipment;
using GymManager.Core.Members;
using GymManger.DataAccess;
using GymManger.DataAccess.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Wkhtmltopdf.NetCore;

namespace GymManager.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
                Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("Default");

            services.AddDbContext<GymManagerContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<GymManagerContext>().AddUserStore<UserStore<IdentityUser, IdentityRole, GymManagerContext>>();

            services.ConfigureApplicationCookie(options => options.LoginPath = "/Account/LogIn");

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            
            services.AddTransient<IMembersAppService, MembersAppService>();
            services.AddTransient<IMembershipTypesAppService, MembershipTypesAppService>();
            services.AddTransient<IEquipmentAppService, EquipmentAppService>();

            services.AddTransient<IMenuAppService, MenuAppService>();
            services.AddTransient<IRepository<int, Member>, MembersRepository>();
			services.AddTransient<IRepository<int, MembershipType>, MembershipTypeRepository>();
            services.AddTransient<IRepository<int, EquipmentInventory>, EquipmentRepository>();

            services.AddWkhtmltopdf();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var DefaultDateCulture = "es-MX";
            var ci = new CultureInfo(DefaultDateCulture);

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(ci),
                SupportedCultures = new List<CultureInfo>
                {
                    ci,
                },
                SupportedUICultures = new List<CultureInfo>
                { 
                ci,
                }
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=home}/{action=Index}/{id?}");
            });
        }
    }
}
