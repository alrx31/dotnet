using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFc.Models;

[Table("Grades")]
public class Grade
{
    public Grade()
    {
        Students = new List<Student>();
    }
    
    [Key]
    public int GradeId { get; set; }
    [Column("GradeName", TypeName = "ntext")]
    [MaxLength(50)]
    public string GradeName { get; set; }
    
    public IList<Student> Students { get; set; }

}