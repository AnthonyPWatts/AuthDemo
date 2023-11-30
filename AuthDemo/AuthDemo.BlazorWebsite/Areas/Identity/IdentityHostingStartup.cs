using AuthDemo.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AuthDemo.BlazorWebsite.Areas.Identity.IdentityHostingStartup))]
namespace AuthDemo.BlazorWebsite.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuthDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DefaultConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options =>
                        options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<AuthDbContext>();
            });
        }
    }
}