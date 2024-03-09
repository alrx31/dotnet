using System.ComponentModel.DataAnnotations;

namespace onlineshop.Models;

public class Size
{
    [Key]
    public int SizeId { get; set; }
    [MaxLength(50)]
    public string SizeName { get; set; }
    
    public List<ProductVariant> ProductVariants { get; set; }
}