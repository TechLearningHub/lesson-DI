using lesson_DI.Interfaces;
using lesson_DI.Models;

namespace lesson_DI.Services;

public class InventoryService : IInventoryService
{
    public Task<bool> CheckInventoryAsync(Order order)
    {
        //Some logic implementations
        throw new NotImplementedException();
    }
}