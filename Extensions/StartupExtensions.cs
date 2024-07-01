using Recycle.Repositories;
using Recycle.Repositories.Context;
using Recycle.Repository;
using Recycle.Services;

namespace Recycle.Extensions
{
    public static class StartupExtensions
    {
        public static void AddDependencies(this IServiceCollection services) {

            services.AddScoped<RecycleContext>();

            services.AddTransient<ITruckService, TruckService>();
            services.AddTransient<ITruckRepository, TruckRepository>();

            services.AddTransient<ISchedulingService, SchedulingService>();
            services.AddTransient<ISchedulingRepository, SchedulingRepository>();
        }

    }
}
