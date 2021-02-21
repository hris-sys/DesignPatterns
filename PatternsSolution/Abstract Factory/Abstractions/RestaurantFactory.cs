namespace Abstract_Factory.Abstractions
{
    using Models;

    public abstract class RestaurantFactory
    {
        public abstract Soup CreateSoup();

        public abstract Meal CreateMeal();

        public abstract Dessert CreateDessert();
    }
}
