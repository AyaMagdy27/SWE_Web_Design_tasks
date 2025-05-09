using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        int largest = num1;

        if (num2 > largest)
            largest = num2;
        if (num3 > largest)
            largest = num3;

        Console.WriteLine("Largest number is: " + largest);
    }
}
