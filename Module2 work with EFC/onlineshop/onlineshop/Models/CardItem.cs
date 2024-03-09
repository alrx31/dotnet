using System.ComponentModel.DataAnnotations;

namespace onlineshop.Models;

public class CardItem
{
    [Key]
    public int ProductVariantId { get; set; }
    public ProductVariant ProductVariant { get; set; }
    
    public int Quantity { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
}