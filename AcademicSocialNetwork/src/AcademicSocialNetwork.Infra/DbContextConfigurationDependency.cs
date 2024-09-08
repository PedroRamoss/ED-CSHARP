using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AcademicSocialNetwork.Infra
{
    public static class DbContextConfigurationDependency
    {
        public static void AddDbContextConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AcademicSocialNetworkDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
