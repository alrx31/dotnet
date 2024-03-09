using System.ComponentModel.DataAnnotations;

namespace onlineshop.Models;

public class Brand
{
    [Key]
    public int BrandId { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }
    
    public List<Product> Products { get; set; }
}