using Common.Interfaces;
using Common.Models;

namespace Common.Services;

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