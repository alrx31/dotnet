using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onlineshop.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }
    [MaxLength(50)]
    public string CategoryName { get; set; }

    public int ParentCategoryId { get; set; }
    
    public Category ParentCategory { get; set; }
    public List<Category> SubCategories { get; set; }
    
    public List<Product> Products { get; set; }
    public List<SectionCategory> SectionsCategories { get; set; }
    
}