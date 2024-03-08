using EFc.Models;
using EFc.ControllersT;
using Microsoft.Extensions.Configuration;


using var context = new SchoolDbContext();
context.Database.EnsureCreated();



foreach (var student in context.Students)
{
    Console.WriteLine(student.FirstName + " " + student.LastName);
}

Console.WriteLine();
foreach (var grade in context.Grades)
{
    Console.WriteLine(grade.GradeName);
}
{
    
}