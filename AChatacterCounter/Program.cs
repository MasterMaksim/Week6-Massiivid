﻿using System;

namespace AChatacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi: ");
            string firstName = Console.ReadLine().ToLower();
            Console.WriteLine("Sisesta perekonnanimi: ");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();
            Console.WriteLine(fullName);

            int aCounter = 0;

            for(int i = 0; i < fullName.Length; i++)
            {
                if(fullName[i] == 'a')
                {
                    aCounter++;
                }
            }

            if(aCounter != 1)
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} a tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} a täht.");
            }

            
        }
    }
}
