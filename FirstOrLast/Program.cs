using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis on teie eesnimi?");
            string firstName = Console.ReadLine();
            int firstNameLength = firstName.Length;

            Console.WriteLine("Mis on teie perekonnanimi?");
            string lastName = Console.ReadLine();
            int lastNameLength = lastName.Length;

            if(firstNameLength > lastNameLength)
            {
                Console.WriteLine("Teie eesnimi on pikem!");
            }else if (firstNameLength < lastNameLength)
            {
                Console.WriteLine("Teie perekonnanimi on pikem!");
            }
            else
            {
                Console.WriteLine("Teie eesnimi ja perekonnanimi on sama pikkusega.");
            }
        }
    }
}
