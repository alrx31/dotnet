using System.ComponentModel.DataAnnotations;

namespace onlineshop.Models;

public class Product
{
    [Key]
    public int ProductId { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }
    
    public int BrandId { get; set; }
    public Brand Brand { get; set; }
    
    public int Price { get; set; }
    public float Raiting { get; set; }
    
    public List<Media> Medias { get; set; }
    
    public int CategoryId { get; set; }
    public Category Category { get; set; }     
    //public int ProductVariantId { get; set; }
    
    // Review
    
    
    public List<Review> Reviews { get; set; }
    
    
    
    
}