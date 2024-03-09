using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onlineshop.Models;

public class OrderTransaction
{
    [Key]
    public int OrderId { get; set; }
    public Order Order { get; set; }
    
    public int TransactionStatus { get; set; }
    
    [Column("Transaction Updated At")]
    public DateTime UpdatedAt { get; set; }
}