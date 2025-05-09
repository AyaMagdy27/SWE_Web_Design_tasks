using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int b = Convert.ToInt32(Console.ReadLine());

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After swapping:");
        Console.WriteLine("First number: " + a);
        Console.WriteLine("Second number: " + b);
    }
}
