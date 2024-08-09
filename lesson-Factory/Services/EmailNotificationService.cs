using Common.Interfaces;
using Common.Models;

namespace lesson_Factory.Services;

public class EmailNotificationService : INotificationService
{
    public async Task SendOrderConfirmationAsync(Order order)
    {
        // Some logic
        await Console.Out.WriteLineAsync($"Notification has been sent to the email by order id: {order.OrderId}");
    }
}