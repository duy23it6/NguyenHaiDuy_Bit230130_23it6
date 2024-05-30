using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a character: ");
        string input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input) && input.Length == 1)
        {
            char character = input[0];
            int asciiCode = (int)character;

            Console.WriteLine($"The character you entered is '{character}', its ASCII code is {asciiCode}");
        }
        else
        {
            Console.WriteLine("The value you entered is not a valid single character.");
        }
    }
}
