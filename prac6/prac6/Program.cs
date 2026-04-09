using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "Amit", Department = "HR" },
            new Employee { Id = 2, Name = "Neha", Department = "IT" },
            new Employee { Id = 3, Name = "Rahul", Department = "IT" },
            new Employee { Id = 4, Name = "Sneha", Department = "HR" },
            new Employee { Id = 5, Name = "Karan", Department = "Sales" }
        };

        var result = employees
                     .GroupBy(e => e.Department)
                     .Select(g => new
                     {
                         Department = g.Key,
                         Count = g.Count()
                     });

        Console.WriteLine("Employee Count by Department:\n");

        foreach (var item in result)
        {
            Console.WriteLine(item.Department + " : " + item.Count);
        }
    }
}