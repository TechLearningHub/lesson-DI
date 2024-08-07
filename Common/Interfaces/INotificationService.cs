
using Common.Models;

namespace Common.Interfaces;

public interface INotificationService
{
    Task SendOrderConfirmationAsync(Order order);
}