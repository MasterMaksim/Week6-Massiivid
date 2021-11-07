using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            Console.WriteLine($"In your first name {firstNameLength} characters.");
        }
    }
}
