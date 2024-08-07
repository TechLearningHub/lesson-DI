using Common.Interfaces;
using Common.Models;

namespace Common.Services;

public class NotificationService : INotificationService
{
    public Task SendOrderConfirmationAsync(Order order)
    {
        //Some logic implementations
        throw new NotImplementedException();
    }
}