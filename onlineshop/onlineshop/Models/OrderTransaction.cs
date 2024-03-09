using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onlineshop.Models;

public class OrderTransaction
{
    [Key]
    public int POrderId { get; set; }
    public Order Order { get; set; }
    
    public int TransactionStatus { get; set; }
    
    [MaxLength(100)]
    [Column("Transaction Updated At")]
    public string UpdatedAt { get; set; }
}