using System.ComponentModel.DataAnnotations;

namespace onlineshop.Models;

public class Order
{
    [Key]
    public int OrderId { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
    
    public int Price { get; set; }
    
    public int AddressId { get; set; }
    public Address Address { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public int OrderStatus { get; set; }
    
    public OrderTransaction OrderTransaction { get; set; }
    
    public List<OrderItem> OrderItems { get; set; }
}