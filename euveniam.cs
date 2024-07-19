using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        if (args.Length > 0)
        {
            Console.WriteLine("Command-line arguments:");
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
        else
        {
            Console.WriteLine("No command-line arguments provided.");
        }
    }
}
