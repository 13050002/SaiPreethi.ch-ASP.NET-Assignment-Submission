using WebApplication1.Models;

public class OrderService
{
    public Order CalculateDiscount(Order order)
    {
        if (order.OrderAmount >= 100 && order.CustomerType == "Loyal")
        {
            order.Discount = order.OrderAmount * 0.10m; // 10% discount
        }
        else
        {
            order.Discount = 0;
        }

        order.FinalTotal = order.OrderAmount - order.Discount;
        return order;
    }

    internal object CalculateDiscount1(Order order)
    {
        throw new NotImplementedException();
    }
}
