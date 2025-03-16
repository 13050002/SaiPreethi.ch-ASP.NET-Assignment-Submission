
using WebApplication1.Models;

public class Order
{
    public int OrderAmount { get; set; }
     public string CustomerType { get; set; } = string.Empty; // Avoid null errors
    public decimal Discount { get; set; }
    public decimal FinalTotal { get; set; }
}
