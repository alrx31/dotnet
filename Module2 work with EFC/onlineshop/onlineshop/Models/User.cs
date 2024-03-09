using System.ComponentModel.DataAnnotations;

namespace onlineshop.Models;

public class User
{
    [Key]
    public int UserId { get; set; }
    
    public int UserType { get; set; }
    [MaxLength(50)]
    public string UserEmail { get; set; }
    [MaxLength(50)]
    public string UserPassword { get; set; }
    [MaxLength(50)]
    public string UserPhone { get; set; }
    [MaxLength(50)]
    public string UserFirstName { get; set; }
    [MaxLength(50)]
    public string UserLastName { get; set; }
    
    public List<Review> Reviews { get; set; }
    
}