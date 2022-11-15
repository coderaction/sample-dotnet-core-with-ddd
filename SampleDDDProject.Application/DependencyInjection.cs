using System.Reflection;

namespace SampleDDDProject.Application
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Application projesindeki dependency injection'lari ekler
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void AddApplicationRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = Assembly.GetExecutingAssembly();
            // services.AddAutoMapper(assembly);
            // services.AddMediatR(assembly);
        }
    }
}