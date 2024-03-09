namespace EFc.Models;

public class Grade
{
    public Grade()
    {
        Students = new List<Student>();
    }
    public int GradeId { get; set; }
    public string GradeName { get; set; }
    public IList<Student> Students { get; set; }

}