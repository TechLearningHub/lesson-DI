using Common.Interfaces;
using Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace lesson_InterceptorsDecorators.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderValidator _orderValidator;

    public OrderController(IOrderValidator orderValidator)
    {
        _orderValidator = orderValidator;
    }

    [HttpPost("validate")]
    public async Task<ActionResult<bool>> ValidateAsync(Order order)
    {
        return await _orderValidator.ValidateOrderAsync(order);
    }
}