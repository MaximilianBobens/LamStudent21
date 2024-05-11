using System;
using System.Collections.Generic;
using System.Linq;

namespace LamStudent21;
class Program
{
      static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Max Mustermann", Age = 23, Major = EMajor.ComputerScience, GPA = 1.8, HasGraduated = false },
            new Student { Name = "Erika Mustermann", Age = 24, Major = EMajor.Mathematics, GPA = 1.3, HasGraduated = true },
            new Student { Name = "John Doe", Age = 22, Major = EMajor.Physics, GPA = 2.0, HasGraduated = false },
            new Student { Name = "Jane Doe", Age = 21, Major = EMajor.Chemistry, GPA = 1.7, HasGraduated = false },
            new Student { Name = "Alice Wonderland", Age = 25, Major = EMajor.Biology, GPA = 1.5, HasGraduated = true },
            new Student { Name = "Bob Builder", Age = 26, Major = EMajor.ComputerScience, GPA = 2.1, HasGraduated = true },
            new Student { Name = "Charlie Brown", Age = 27, Major = EMajor.Humanities, GPA = 1.9, HasGraduated = false },
            new Student { Name = "Diana Prince", Age = 22, Major = EMajor.ComputerScience, GPA = 1.4, HasGraduated = false },
            new Student { Name = "Peter Parker", Age = 23, Major = EMajor.Physics, GPA = 1.6, HasGraduated = true },
            new Student { Name = "Clark Kent", Age = 28, Major = EMajor.ComputerScience, GPA = 2.3, HasGraduated = true },
        };

        StudentsOlderThan25(students);
        GraduatedStudents(students);
        ComputerScienceStudents(students);
        StudentNames(students);
        StudentAges(students);
        StudentMajors(students);
        SelectMultipleProperties(students);
        AverageGPA(students);
        LongestName(students);
    }

    static void StudentsOlderThan25(List<Student> students)
    {
        var olderStudents = students.Where(s => s.Age > 25);
        Console.WriteLine("Students older than 25:");
        foreach (var student in olderStudents)
        {
            Console.WriteLine(student.Name);
        }
    }

    static void GraduatedStudents(List<Student> students)
    {
        var graduatedStudents = students.Where(s => s.HasGraduated);
        Console.WriteLine("\nGraduated students:");
        foreach (var student in graduatedStudents)
        {
            Console.WriteLine(student.Name);
        }
    }

    static void ComputerScienceStudents(List<Student> students)
    {
        var csStudents = students.Where(s => s.Major == EMajor.ComputerScience);
        Console.WriteLine("\nComputer Science students:");
        foreach (var student in csStudents)
        {
            Console.WriteLine(student.Name);
        }
    }

    static void StudentNames(List<Student> students)
    {
        var names = students.Select(s => s.Name);
        Console.WriteLine("\nList of student names:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }

    static void StudentAges(List<Student> students)
    {
        var ages = students.Select(s => s.Age);
        Console.WriteLine("\nAges of students:");
        foreach (var age in ages)
        {
            Console.WriteLine(age);
        }
    }

    static void StudentMajors(List<Student> students)
    {
        var majors = students.Select(s => s.Major);
        Console.WriteLine("\nMajors of students:");
        foreach (var major in majors)
        {
            Console.WriteLine(major);
        }
    }

    static void SelectMultipleProperties(List<Student> students)
    {
        var selectedProperties = students.Select(s => new { s.Name, s.Age, s.GPA });
        Console.WriteLine("\nSelected properties (Name, Age, GPA) of students:");
        foreach (var property in selectedProperties)
        {
            Console.WriteLine($"Name: {property.Name}, Age: {property.Age}, GPA: {property.GPA}");
        }
    }

    static void AverageGPA(List<Student> students)
    {
        var averageGPA = students.Average(s => s.GPA);
        Console.WriteLine($"\nAverage GPA of all students: {averageGPA:F2}");
    }

    static void LongestName(List<Student> students)
    {
        var longestName = students.OrderByDescending(s => s.Name.Length).First().Name;
        Console.WriteLine($"\nLongest name among students: {longestName}");
    }
}
