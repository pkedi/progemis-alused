using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            string number = Console.ReadLine();
            int numberParsed = Int16.Parse(number);

            // teen siia if ja else loogikaga vastused
            // nt kui on alla 50, siis tuleb console writeline vastus
            if (numberParsed <= 50)
            {
                Console.WriteLine("Võrdne või väiksem kui 50");
            }
            else
            {
                Console.WriteLine("Suurem kui 50");
            }
            Console.WriteLine("ERROR");
        }
    }
}
