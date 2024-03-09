using System.ComponentModel.DataAnnotations;

namespace onlineshop.Models;

public class OrderItem
{
    [Key]
    public int ProductVariantId { get; set; }
    public ProductVariant ProductVariant { get; set; }
    
    public int OrderId { get; set; }
    public Order Order { get; set; }
    
    public int Quantity { get; set; }
}