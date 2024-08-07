using Common.Interfaces;
using Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace lesson_DI.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController(IOrderValidator orderValidator) : ControllerBase
{
    [HttpPost("validate")]
    public async Task<ActionResult<bool>> ValidateOrder(Order order)
    {
        return await orderValidator.ValidateOrderAsync(order);
    }
}