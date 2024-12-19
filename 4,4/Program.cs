using System;

namespace _4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string lösenord;
            do
            {
                Console.WriteLine("Ange lösenord");
                lösenord = Console.ReadLine();

                if (lösenord != "hemligt")
                {
                    Console.WriteLine("fel lösenord, försök igen!");
                }


            } while (lösenord != "hemligt");
            Console.WriteLine(" Korrekt lösenord! du är inloggad.");
        }
    }
}