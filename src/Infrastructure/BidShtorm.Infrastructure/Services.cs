using BidShtorm.Application.Interfaces;
using BidShtorm.Infrastructure.Common.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BidShtorm.Infrastructure
{
    public static class Services
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
            => services.AddPersistence();

        static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddDbContext<BidShtormDbContext>(options =>
                options.UseSqlite("Data Source = BidShtorm.db"));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<BidShtormDbContext>());

            return services;
        }
    }
}
