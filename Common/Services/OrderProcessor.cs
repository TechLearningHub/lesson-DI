using Common.Interfaces;
using Common.Models;

namespace Common.Services;

public class OrderProcessor
{
    private readonly IOrderValidator _validator;
    private readonly IInventoryService _inventoryService;
    private readonly IPaymentProcessor _paymentProcessor;
    private readonly INotificationService _notificationService;

    public OrderProcessor(IOrderValidator validator,
        IInventoryService inventoryService,
        IPaymentProcessor paymentProcessor,
        INotificationService notificationService)
    {
        _validator = validator;
        _inventoryService = inventoryService;
        _paymentProcessor = paymentProcessor;
        _notificationService = notificationService;
    }

    public async Task ProcessOrderAsync(Order order)
    {
        if (!await _validator.ValidateOrderAsync(order)) return;
        if (!await _inventoryService.CheckInventoryAsync(order)) return;
        if (!await _paymentProcessor.ProcessPaymentAsync(order)) return;

        await _notificationService.SendOrderConfirmationAsync(order);
    }
}