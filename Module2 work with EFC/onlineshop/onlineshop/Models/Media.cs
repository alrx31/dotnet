using System.ComponentModel.DataAnnotations;

namespace onlineshop.Models;

public class Media
{
    [Key]
    public int MediaId { get; set; }
    
    
    public int ProductId { get; set; }
    public Product Product { get; set; }
    
    [MaxLength(50)]
    public string MediaFileType { get; set; }
    [MaxLength(50)]
    public string MediaFileName { get; set; }
    [MaxLength(50)]
    public string MediaBytes { get; set; }
}