using Common.Interfaces;
using Common.Models;

namespace lesson_InterceptorsDecorators.Decorators;

public class OrderValidatorDecorator : IOrderValidator
{
    private readonly IOrderValidator _orderValidator;
    private readonly ILogger<OrderValidatorDecorator> _logger;

    public OrderValidatorDecorator(
        IOrderValidator orderValidator,
        ILogger<OrderValidatorDecorator> logger)
    {
        _orderValidator = orderValidator;
        _logger = logger;
    }

    public async Task<bool> ValidateOrderAsync(Order order)
    {
        _logger.LogInformation("Start execution of the validating order");
        var result = await _orderValidator.ValidateOrderAsync(order);
        _logger.LogInformation("Finished validating process of the order");
        return result;
    }
}