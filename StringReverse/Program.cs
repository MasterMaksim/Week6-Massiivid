using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta sinu eesnimi: ");
            string firstName = Console.ReadLine().ToLower();

            for(int i = firstName.Length-1; i >= 0; i--)
            {
                Console.Write(firstName[i]);
            }
        }
    }
}
