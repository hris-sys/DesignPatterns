namespace Abstract_Factory.Implementations
{
    using System;
    using Abstractions;
    using Abstractions.Models;

    using Models.Desserts;
    using Models.Meals;
    using Models.Soups;

    public class BulgarianRestaurant : RestaurantFactory
    {
        public override Dessert CreateDessert()
        {
            return new IceCream();
        }

        public override Meal CreateMeal()
        {
            return new Banitsa();
        }

        public override Soup CreateSoup()
        {
            return new Tarator();
        }
    }
}
