using lesson_DI.Interfaces;
using lesson_DI.Models;

namespace lesson_DI.Services;

public class OrderValidator : IOrderValidator
{
    public Task<bool> ValidateOrderAsync(Order order)
    {
        //Some logic implementations
        if (order.OrderId > 0)
        {
            return Task.FromResult(true);
        }
        return Task.FromResult(false);
    }
}