using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter four numbers:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());
        int num4 = Convert.ToInt32(Console.ReadLine());

        double average = (num1 + num2 + num3 + num4) / 4.0;
        Console.WriteLine("Average: " + average);
    }
}
