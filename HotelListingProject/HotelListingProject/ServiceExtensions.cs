using HotelListing.Data;
using HotelListing.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingProject
{
    public static class ServiceExtensions
    {
        public static void ConfigureIdentity(this IServiceCollection services) 
        {
            var builder = services.AddIdentityCore<AppUser>(q 
                => q.User.RequireUniqueEmail = true);

            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), services);
            builder.AddEntityFrameworkStores<Context>().AddDefaultTokenProviders();
        }
    }
}
