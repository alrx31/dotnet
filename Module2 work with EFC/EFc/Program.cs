using EFc.Models;
using EFc.ControllersT;
using Microsoft.Extensions.Configuration;


using var context = new SchoolDbContext();
context.Database.EnsureCreated();

String[] names = new String[] { "John", "Paul", "George", "Ringo","alex" };

var myLINQ = from name in names
    where name.Contains('a')
    select name;


foreach (var name in myLINQ)
{
    Console.WriteLine(name);
}

foreach (var student in context.Students)
{
    Console.WriteLine(student.FirstName + " " + student.LastName);
}

Console.WriteLine();
foreach (var grade in context.Grades)
{
    Console.WriteLine(grade.GradeName);
}