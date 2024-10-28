using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Unesite string:");
        string input = Console.ReadLine();

        if (input.Length < 5)
        {
            Console.WriteLine(input);
        }
        else
        {
            string result = input.Substring(2, input.Length - 4);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
