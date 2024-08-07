
using Common.Models;

namespace Common.Interfaces;

public interface IInventoryService
{
    Task<bool> CheckInventoryAsync(Order order);
}