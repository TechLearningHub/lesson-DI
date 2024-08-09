using Castle.DynamicProxy;

namespace lesson_InterceptorsDecorators.Interceptors;

public class OrderValidatorInterceptor : IInterceptor
{
    private readonly ILogger<OrderValidatorInterceptor> _logger;

    public OrderValidatorInterceptor(ILogger<OrderValidatorInterceptor> logger)
    {
        _logger = logger;
    }

    public void Intercept(IInvocation invocation)
    {
        _logger.LogInformation($"Calling method {invocation.Method.Name} with parameters {string.Join(", ", invocation.Arguments)}");
        invocation.Proceed();
        _logger.LogInformation($"Method {invocation.Method.Name} returned {invocation.ReturnValue}");
    }
}