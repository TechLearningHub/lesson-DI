using Common.Interfaces;
using Common.Models;

namespace Common.Services;

public class InventoryService : IInventoryService
{
    public Task<bool> CheckInventoryAsync(Order order)
    {
        //Some logic implementations
        throw new NotImplementedException();
    }
}