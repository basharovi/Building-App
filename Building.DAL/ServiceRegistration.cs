using Building.DAL.Repositories;
using Building.DAL.UniOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace Building.DAL
{
    public static class ServiceRegistration
    {
        public static void AddDataAccessLayer(this IServiceCollection services)
        {
            services.AddTransient<IReadingRepository, ReadingRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
