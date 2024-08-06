using lesson_DI.Interfaces;
using lesson_DI.Models;

namespace lesson_DI.Services;

public class NotificationService : INotificationService
{
    public Task SendOrderConfirmationAsync(Order order)
    {
        //Some logic implementations
        throw new NotImplementedException();
    }
}