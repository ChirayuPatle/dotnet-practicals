using System;
class Program
{
    static void Main()
    {
        int num1, num2, result;

        try
        {
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = num1 / num2;

            Console.WriteLine("Result = " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numbers!");
        }
    }
}