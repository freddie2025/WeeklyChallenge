using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebUI.Areas.Identity.Data;
using WebUI.Data;

[assembly: HostingStartup(typeof(WebUI.Areas.Identity.IdentityHostingStartup))]
namespace WebUI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WebUIContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("WebUIContextConnection")));

                services.AddDefaultIdentity<WebUIUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<WebUIContext>();
            });
        }
    }
}