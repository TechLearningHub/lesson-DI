using lesson_DI.Models;

namespace lesson_DI.Interfaces;

public interface INotificationService
{
    Task SendOrderConfirmationAsync(Order order);
}