using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a floating-point number: ");
        string input = Console.ReadLine();

        double doubleNumber;
        if (double.TryParse(input, out doubleNumber))
        {
            int intNumber = (int)doubleNumber;
            long longNumber = (long)doubleNumber;

            Console.WriteLine($"The number you entered is {doubleNumber}, as an integer is {intNumber}, and as a long is {longNumber}");
        }
        else
        {
            Console.WriteLine("The value you entered is not a valid floating-point number.");
        }
    }
}
