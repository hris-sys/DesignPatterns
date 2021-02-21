namespace Abstract_Factory
{
    using System;

    using Abstractions;
    using Abstractions.Models;

    public class Cheff
    {
        private readonly RestaurantFactory restaurantFactory;

        private Soup soup;
        private Meal meal;
        private Dessert dessert;

        public Cheff(RestaurantFactory restaurantFactory)
        {
            this.restaurantFactory = restaurantFactory;

            this.soup = restaurantFactory.CreateSoup();
            this.meal = restaurantFactory.CreateMeal();
            this.dessert = restaurantFactory.CreateDessert();
        }

        public void GetMenu()
        {
            Console.WriteLine(soup.GetType().Name);
            Console.WriteLine(meal.GetType().Name);
            Console.WriteLine(dessert.GetType().Name);
        }
    }
}
