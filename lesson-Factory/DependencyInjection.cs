using Common.Interfaces;
using lesson_Factory.Services;

namespace lesson_Factory;

public static class DependencyInjection
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddTransient<NotificationServiceFactory>();
    }
}