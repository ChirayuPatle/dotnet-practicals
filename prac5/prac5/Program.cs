using System;
using System.Collections.Generic;
using System.Linq;

// Generic Repository
class Repository<T>
{
    private List<T> data = new List<T>();

    // CREATE
    public void Add(T item)
    {
        data.Add(item);
    }

    // READ
    public List<T> GetAll()
    {
        return data;
    }

    // UPDATE
    public void Update(int index, T newItem)
    {
        if (index >= 0 && index < data.Count)
            data[index] = newItem;
    }

    // DELETE
    public void Delete(int index)
    {
        if (index >= 0 && index < data.Count)
            data.RemoveAt(index);
    }
}

// Student Class
class Student
{
    public int Id;
    public string Name;

    public override string ToString()
    {
        return $"Student -> Id: {Id}, Name: {Name}";
    }
}

// Employee Class
class Employee
{
    public int Id;
    public string Name;

    public override string ToString()
    {
        return $"Employee -> Id: {Id}, Name: {Name}";
    }
}

class Program
{
    static void Main()
    {
        // Student Repository
        Repository<Student> studentRepo = new Repository<Student>();
        studentRepo.Add(new Student { Id = 1, Name = "Chirayu" });
        studentRepo.Add(new Student { Id = 2, Name = "Rahul" });

        Console.WriteLine("Students:");
        foreach (var s in studentRepo.GetAll())
            Console.WriteLine(s);

        // Employee Repository
        Repository<Employee> empRepo = new Repository<Employee>();
        empRepo.Add(new Employee { Id = 101, Name = "Amit" });
        empRepo.Add(new Employee { Id = 102, Name = "Neha" });

        Console.WriteLine("\nEmployees:");
        foreach (var e in empRepo.GetAll())
            Console.WriteLine(e);
    }
}