using Common.Models;

namespace Common.Interfaces;

public interface IOrderValidator
{
    Task<bool> ValidateOrderAsync(Order order);
}