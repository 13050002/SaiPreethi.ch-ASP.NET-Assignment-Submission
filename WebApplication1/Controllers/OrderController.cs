using Microsoft.AspNetCore.Mvc;
//using OrderProcessingSystem.Models;
//using OrderProcessingSystem.Services;

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
