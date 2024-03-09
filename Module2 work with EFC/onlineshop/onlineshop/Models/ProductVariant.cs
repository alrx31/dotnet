using System.ComponentModel.DataAnnotations;

namespace onlineshop.Models;

public class ProductVariant
{
    [Key]
    public int ProductVariantId { get; set; }
    
    public int ProductId { get; set; }
    public Product Product { get; set; }
    
    public int SizeId { get; set; }
    public Size Size { get; set; }
    
    public int ColorId { get; set; }
    public Color Color { get; set; }
    
    public int Quantity { get; set; }
    
    [MaxLength(50)]
    public string Sku { get; set; }
    
    // card items
    
    public List<CardItem> CardItems { get; set; }
    
    public OrderItem OrderItem { get; set; }
}