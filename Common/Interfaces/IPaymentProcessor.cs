
using Common.Models;

namespace Common.Interfaces;

public interface IPaymentProcessor
{
    Task<bool> ProcessPaymentAsync(Order order);
}