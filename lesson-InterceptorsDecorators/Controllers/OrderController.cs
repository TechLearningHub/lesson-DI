using Castle.DynamicProxy;
using Common.Interfaces;
using Common.Models;
using Common.Services;
using lesson_InterceptorsDecorators.Interceptors;
using Microsoft.AspNetCore.Mvc;

namespace lesson_InterceptorsDecorators.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderValidator _orderValidator;

    public OrderController(IOrderValidator orderValidator)
    {
        _orderValidator = orderValidator;
    }

    [HttpPost("validate-decorate")]
    public async Task<ActionResult<bool>> ValidateDecorateAsync(Order order)
    {
        return await _orderValidator.ValidateOrderAsync(order);
    }

    [HttpPost("validate-intercept")]
    public async Task<ActionResult<bool>> ValidateInterceptAsync(Order order)
    {
        var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder
                .AddConsole()
                .AddDebug()
                .SetMinimumLevel(LogLevel.Information);
        });
        var logger = loggerFactory.CreateLogger<OrderValidatorInterceptor>();
        var proxyGenerator = new ProxyGenerator();
        var orderValidator = proxyGenerator.CreateInterfaceProxyWithTarget<IOrderValidator>(
            new OrderValidator(),
            new OrderValidatorInterceptor(logger));

        return await orderValidator.ValidateOrderAsync(order);
    }
}