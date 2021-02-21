namespace Abstract_Factory.Implementations
{
    using Abstractions;
    using Abstractions.Models;

    using Models.Desserts;
    using Models.Meals;
    using Models.Soups;

    public class EnglishRestaurant : RestaurantFactory
    {
        public override Dessert CreateDessert()
        {
            return new Souffle();
        }

        public override Meal CreateMeal()
        {
            return new Mussaka();
        }

        public override Soup CreateSoup()
        {
            return new ChickenSoup();
        }
    }
}
