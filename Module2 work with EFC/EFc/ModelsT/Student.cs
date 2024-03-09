namespace EFc.Models;

public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public byte[] Photo { get; set; }
    public decimal Height { get; set; }
    public float Weight { get; set; }
    public int GradeId { get; set; }
    
    public Grade Grade { get; set; }
    
    public int StudentAddressId { get; set; }
    public StudentAddress Address { get; set; }
    
    public IList<StudentCourse> StudentCourses { get; set; }
}
