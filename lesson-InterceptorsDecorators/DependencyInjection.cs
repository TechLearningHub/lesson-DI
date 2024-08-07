using Common.Interfaces;
using Common.Services;
using lesson_InterceptorsDecorators.Decorators;

namespace lesson_InterceptorsDecorators;

public static class DependencyInjection
{
    public static void AddCollectionServices(this IServiceCollection services)
    {
        services.AddLoggingLayer();
        services.AddServices();
        services.AddDecoratorLayer();
    }

    private static void AddLoggingLayer(this IServiceCollection services)
    {
        services.AddLogging(builder => builder.AddConsole());
    }

    private static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IOrderValidator, OrderValidator>();
    }

    private static void AddDecoratorLayer(this IServiceCollection services)
    {
        services.Decorate<IOrderValidator, OrderValidatorDecorator>();
    }
}