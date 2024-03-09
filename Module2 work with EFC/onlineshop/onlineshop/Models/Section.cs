using System.ComponentModel.DataAnnotations;

namespace onlineshop.Models;

public class Section
{
    [Key]
    public int SectionId { get; set; }
    
    [MaxLength(50)]
    public string SectionName { get; set; }
    
    public SectionCategory SectionCategory { get; set; }
}