using Factory_Method_Pattern.BottleCreators;
using System;

namespace Factory_Method_Pattern
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var cocaColaCreator = new CocaColaCreator();
            var cocaCola = cocaColaCreator.CreateBottle();

            Console.WriteLine(cocaCola.Name);
            Console.WriteLine(cocaCola.Material);
            Console.WriteLine(cocaCola.Capacity + " ml.");
        }
    }
}
