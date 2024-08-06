using lesson_DI.Interfaces;
using lesson_DI.Models;
using Microsoft.AspNetCore.Mvc;

namespace lesson_DI.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController(IOrderValidator orderValidator) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<bool>> ValidateOrder(Order order)
    {
        return await orderValidator.ValidateOrderAsync(order);
    }
}