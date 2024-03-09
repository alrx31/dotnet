using System.ComponentModel.DataAnnotations;

namespace onlineshop.Models;

public class SectionCategory
{
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    
    public int SectionId { get; set; }
    public Section Section { get; set; }
    
    
}