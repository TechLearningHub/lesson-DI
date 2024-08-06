using lesson_DI.Models;

namespace lesson_DI.Interfaces;

public interface IOrderValidator
{
    Task<bool> ValidateOrderAsync(Order order);
}