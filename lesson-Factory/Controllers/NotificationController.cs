using Common.Models;
using Common.Services;
using lesson_Factory.Services;
using Microsoft.AspNetCore.Mvc;

namespace lesson_Factory.Controllers;

[ApiController]
[Route("[controller]")]
public class NotificationController : ControllerBase
{
    [HttpPost("email")]
    public async Task SendNotificationToEmail([FromBody] Order order)
    {
        var notificationFactory = new NotificationServiceFactory();
        var emailNotificationService = notificationFactory.CreateNotificationService(nameof(EmailNotificationService));
        await emailNotificationService.SendOrderConfirmationAsync(order);
    }
    
    [HttpPost("Sms")]
    public async Task SendNotificationAsSms([FromBody] Order order)
    {
        var notificationFactory = new NotificationServiceFactory();
        var emailNotificationService = notificationFactory.CreateNotificationService(nameof(SmsNotificationService));
        await emailNotificationService.SendOrderConfirmationAsync(order);
    }
    
    [HttpPost("push-notification")]
    public async Task SendNotificationAsPushNotification([FromBody] Order order)
    {
        var notificationFactory = new NotificationServiceFactory();
        var emailNotificationService = notificationFactory.CreateNotificationService(nameof(NotificationService));
        await emailNotificationService.SendOrderConfirmationAsync(order);
    }
}