using System.ComponentModel.DataAnnotations;

namespace onlineshop.Models;

public class Review
{
    [Key]
    public int ReviewId { get; set; }
    
    public int ProductId { get; set; }
    public Product Product { get; set; }
    
    [MaxLength(50)]
    public string ReviewTitle { get; set; }
    
    public int ReviewRaing { get; set; }
    [MaxLength(2000)]
    public string ReviewComment { get; set; }
    
    public DateTime ReviewCreatedAt { get; set; }
    
    
    public int UserId { get; set; }
    public User User { get; set; }
    
}