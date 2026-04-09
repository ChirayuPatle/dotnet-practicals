using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Student(int id, string name, int age, string course)
        {
            Id = id;
            Name = name;
            Age = age;
            Course = course;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}, Course: {Course}");
        }
    }

    class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Student added successfully!");
        }

        public void DisplayAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            foreach (var student in students)
            {
                student.Display();
            }
        }

        public void SearchStudent(int id)
        {
            var student = students.Find(s => s.Id == id);

            if (student != null)
                student.Display();
            else
                Console.WriteLine("Student not found.");
        }

        public void DeleteStudent(int id)
        {
            var student = students.Find(s => s.Id == id);

            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student deleted successfully!");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            int choice;

            do
            {
                Console.WriteLine("\n--- Student Management System ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display All Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Course: ");
                        string course = Console.ReadLine();

                        manager.AddStudent(new Student(id, name, age, course));
                        break;

                    case 2:
                        manager.DisplayAllStudents();
                        break;

                    case 3:
                        Console.Write("Enter ID to search: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        manager.SearchStudent(searchId);
                        break;

                    case 4:
                        Console.Write("Enter ID to delete: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        manager.DeleteStudent(deleteId);
                        break;

                    case 5:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 5);
        }
    }
}