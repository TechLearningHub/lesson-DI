using Common.Interfaces;
using Common.Services;

namespace lesson_Factory.Services;

public class NotificationServiceFactory
{
    public INotificationService CreateNotificationService(string service)
    {
        return service switch
        {
            nameof(EmailNotificationService) => new EmailNotificationService(),
            nameof(SmsNotificationService) => new SmsNotificationService(),
            nameof(NotificationService) => new NotificationService(),
            _ => throw new KeyNotFoundException("Does not exist such service")
        };
    }
}