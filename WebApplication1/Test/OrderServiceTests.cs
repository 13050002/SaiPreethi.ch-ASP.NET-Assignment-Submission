using WebApplication1.Models;
using Xunit;
//using OrderProcessingSystem.Models;
//using OrderProcessingSystem.Services;

public class OrderServiceTests
{
    private readonly OrderService _service = new OrderService();

    [Fact]
    public void Discount_Applied_For_Loyal_Customer()
    {
        var order = new Order { OrderAmount = 100, CustomerType = "Loyal" };
        var result = _service.CalculateDiscount(order);

        Assert.Equal(10, result.Discount);
        Assert.Equal(90, result.FinalTotal);
    }

    [Fact]
    public void No_Discount_For_New_Customer()
    {
        var order = new Order { OrderAmount = 100, CustomerType = "New" };
        var result = _service.CalculateDiscount(order);

        Assert.Equal(0, result.Discount);
        Assert.Equal(100, result.FinalTotal);
    }
}
