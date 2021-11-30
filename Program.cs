using System;

namespace Humans
{
    class Program
    {
        static void Main(string[] args)
        {
            // Human giles = new Human();
            // giles.Name = "Giles";
            // System.Console.WriteLine(giles.Name);

            Human gilesTest = new Human("Giles", 100, 100, 100);
            System.Console.WriteLine(gilesTest);

            Human gT3 = new Human("Giles3", 150, 75, 82);
            System.Console.WriteLine(gT3);

            int newHealth = gilesTest.Attack(gT3);
        }
    }
}
