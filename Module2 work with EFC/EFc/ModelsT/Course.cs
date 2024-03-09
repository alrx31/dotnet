namespace EFc.Models;

public class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }

    public IList<StudentCourse> StudentCourses { get; set; }
}