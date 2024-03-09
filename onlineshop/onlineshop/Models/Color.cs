using System.ComponentModel.DataAnnotations;

namespace onlineshop.Models;

public class Color
{
    [Key]
    public int ColorId { get; set; }
    [MaxLength(50)]
    public string ColorName { get; set; }
    
    public List<ProductVariant> ProductVariants { get; set; }
}