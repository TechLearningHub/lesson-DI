using lesson_DI.Models;

namespace lesson_DI.Interfaces;

public interface IPaymentProcessor
{
    Task<bool> ProcessPaymentAsync(Order order);
}