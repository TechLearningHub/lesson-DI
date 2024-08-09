using Common.Interfaces;
using Common.Models;

namespace Common.Services;

public class NotificationService : INotificationService
{
    public async Task SendOrderConfirmationAsync(Order order)
    {
        //Some logic implementations
        await Console.Out.WriteLineAsync($"Push notification has been sent by order id: {order.OrderId}.");
    }
}