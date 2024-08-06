using lesson_DI.Interfaces;
using lesson_DI.Models;

namespace lesson_DI.Services;

public class PaymentProcessor : IPaymentProcessor
{
    public Task<bool> ProcessPaymentAsync(Order order)
    {
        //Some logic implementations
        throw new NotImplementedException();
    }
}