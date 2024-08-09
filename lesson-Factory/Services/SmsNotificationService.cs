using Common.Interfaces;
using Common.Models;

namespace lesson_Factory.Services;

public class SmsNotificationService : INotificationService
{
    public async Task SendOrderConfirmationAsync(Order order)
    {
        // Some logic
        await Console.Out.WriteLineAsync($"SMS notification has been sent by order id: {order.OrderId}.");
    }
}