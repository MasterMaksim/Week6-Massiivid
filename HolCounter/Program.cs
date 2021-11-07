using System;

namespace HolCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta: Hello World!");
            string helloWorld = Console.ReadLine().ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'h')
                {
                    hCounter++;
                }
                else if (helloWorld[i] == 'o')
                {
                    oCounter++;
                }
                else if (helloWorld[i] == 'l')
                {
                    lCounter++;
                }
            }

            Console.WriteLine($"Sinu sõnumis on {hCounter} 'h' täht, {lCounter} 'l' tähte ja {oCounter} 'o' tähte.");


        }
    }
}
