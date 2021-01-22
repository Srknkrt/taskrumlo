using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TasKrumIo.Areas.Identity.Data;
using TasKrumIo.Data;

[assembly: HostingStartup(typeof(TasKrumIo.Areas.Identity.IdentityHostingStartup))]
namespace TasKrumIo.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
               


                services.AddDefaultIdentity<TasKrumIoUser>(options =>
                {

                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireDigit = false;
                   
                    

                })
                    .AddEntityFrameworkStores<TasKrumIoContext>();
            
              
            });

        }
    }
}