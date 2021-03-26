using Building.BLL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Building.BLL
{
    public static class ServiceRegistration
    {
        public static void AddBusinessLogicLayer(this IServiceCollection services)
        {
            services.AddTransient<IReadingService, ReadingService>();
            services.AddTransient<IDropdownLoadService, DropdownLoadService>();
        }
    }
}
