using System;

class Student
{
    public int rollNo;
    public string name;

    public void Display()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
    }
}
class Program
{
    static void Main()
    {
        Student s = new Student();

        s.rollNo = 1;
        s.name = "Chirayu";

        s.Display();
    }
}