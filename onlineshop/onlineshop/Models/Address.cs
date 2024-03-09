using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onlineshop.Models;

public class Address
{
    [Key]
    public int AddressId { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
    
    [MaxLength(50)]
    [Column("Address", TypeName = "varchar(50)")]
    public string AddressText { get; set; }

    public List<Order> Orders { get; set; }
}