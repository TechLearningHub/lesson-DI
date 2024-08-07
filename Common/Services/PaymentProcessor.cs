using Common.Interfaces;
using Common.Models;

namespace Common.Services;

public class PaymentProcessor : IPaymentProcessor
{
    public Task<bool> ProcessPaymentAsync(Order order)
    {
        //Some logic implementations
        throw new NotImplementedException();
    }
}