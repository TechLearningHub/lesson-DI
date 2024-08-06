using lesson_DI.Models;

namespace lesson_DI.Interfaces;

public interface IInventoryService
{
    Task<bool> CheckInventoryAsync(Order order);
}