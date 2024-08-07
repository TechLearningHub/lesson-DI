using Common.Interfaces;
using Common.Services;

namespace lesson_DI;

public static class DependencyInjection
{
    public static void AddTransientServices(this IServiceCollection services)
    {
        //For 'Transient' a new instance is created every time a service is requested.
        services.AddTransient<IOrderValidator, OrderValidator>();
        services.AddTransient<IInventoryService, InventoryService>();
        services.AddTransient<IPaymentProcessor, PaymentProcessor>();
        services.AddTransient<INotificationService, NotificationService>();
    }
}