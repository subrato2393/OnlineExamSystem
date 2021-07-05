using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineExam.Membership.Contexts;
using OnlineExam.Membership.Entities;
using OnlineExam.Organization;
using OnlineExam.Organization.Contexts;
using OnlineExam.Web.Services;
using System;

namespace OnlineExam.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public static ILifetimeScope AutofacContainer { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            string migrationAssemblyName = typeof(Startup).Assembly.FullName;

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<OrganizationDbContext>(options =>
               options.UseSqlServer(connectionString,
               options =>options.MigrationsAssembly(migrationAssemblyName)));

            //Identity authentication
            services.AddIdentity<ApplicationUser, Role>()
            .AddUserManager<UserManager>()
            .AddSignInManager<SignInManager>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultUI()
            .AddDefaultTokenProviders();

            //Configure cookie and return url path
            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = new PathString("/Account/AccessDenied");
                options.LoginPath = new PathString("/Account/OrganizationLogin");
            });

            //Authorization
            services.AddAuthorization(options =>
            {
                options.AddPolicy("OrganizationAccess", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim("Organization");
                });
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            string migrationAssemblyName = typeof(Startup).Assembly.FullName;

            builder.RegisterModule(new WebModule());
            builder.RegisterModule(new OrganizationModule(connectionString,migrationAssemblyName));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            AutofacContainer = app.ApplicationServices.GetAutofacRoot();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "areas",
                   pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
