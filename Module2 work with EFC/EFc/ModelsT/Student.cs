using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFc.Models;

[Table("Students")]
public class Student
{
    [Column("StudentId")]
    [Key]
    public int StudentId { get; set; }
    [Column("FirstName", TypeName = "ntext")]
    [MaxLength(50)]
    
    public string FirstName { get; set; }
    [Column("LastName", TypeName = "ntext")]
    [MaxLength(50)]
    public string LastName { get; set; }
    [Column("DateOfBirth", TypeName = "DATE")]
    
    public DateTime DateOfBirth { get; set; }
    [Column("Photo", TypeName = "image")]
    
    public byte[] Photo { get; set; }
    [Column("Height", TypeName = "decimal(5, 2)")]
    public decimal Height { get; set; }
    [Column("Weight", TypeName = "decimal(5, 2)")]
    public float Weight { get; set; }
    [Column("GradeId")]
    [ForeignKey("GrdId")]
    public int GradeId { get; set; }
    
    public Grade Grade { get; set; }
}
