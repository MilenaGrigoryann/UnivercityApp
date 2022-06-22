using Microsoft.Extensions.DependencyInjection;
using University.Services.Implementation;
using University.Services.Interfaces;

namespace University.Services
{
    public static class DependancyInjections
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            return services;
        }
    }
}