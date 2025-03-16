using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
//using WebApplication1.Services;

public class OrderController : Controller
{
    private readonly OrderService _orderService;

    public OrderController(OrderService orderService)
    {
        _orderService = orderService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ProcessOrder(Order order)
    {
        var result = _orderService.CalculateDiscount(order);
        return View("Result", result);
    }
}
