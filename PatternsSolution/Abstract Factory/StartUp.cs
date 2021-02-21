using Abstract_Factory.Implementations;
using System;

namespace Abstract_Factory
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var bulgarianRestaurant = new BulgarianRestaurant();

            var bgCheff = new Cheff(bulgarianRestaurant);

            bgCheff.GetMenu();

            Console.WriteLine();

            var englishRestaurant = new EnglishRestaurant();

            var englishCheff = new Cheff(englishRestaurant);

            englishCheff.GetMenu();
        }
    }
}
