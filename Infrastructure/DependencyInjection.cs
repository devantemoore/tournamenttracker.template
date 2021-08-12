using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tournamenttracker.template.Infrastructure.Persistance;

namespace tournamenttracker.template.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // add infrastructure services


            if (configuration.GetValue<bool>("UseInMemoryDatabase")) {
                
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseInMemoryDatabase("TournamentTrackerDb"));
            } 
            else
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection"),
                        b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            }

            return services;
        }
    }
}
