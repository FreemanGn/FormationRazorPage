using Formation_Web_ASP.NET_Core.Models;
using Formation_Web_ASP.NET_Core.Repositories;

namespace Formation_Web_ASP.NET_Core.Repository
{
    public class RestaurantRepository : IRestaurantRepository
    {

        public RestaurantRepository()
        {
            Restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Id = 1,
                    Name = "Burger King",
                    Description ="Restaurant spécialisé dans les burger",
                    Addresse ="9 Rue Oued Sebou"

                },
                 new Restaurant()
                {
                    Id = 2,
                    Name = "Pizza Hut",
                    Description ="Restaurant spécialisé dans les pizzas",
                    Addresse ="22 Rue Ibn Sina"
                },
                new Restaurant()
                {
                    Id = 3,
                    Name = "KFC",
                    Description ="Restaurant spécialisé dans le poulet frit",
                    Addresse ="13 Rue Ibn Batouta"
                },
                new Restaurant()
                {
                    Id = 4,
                    Name = "McDonald's",
                    Description ="Restaurant de fast-food",
                    Addresse ="4 Rue Ibn Khaldoun"
                },
                new Restaurant()
                {
                    Id = 5,
                    Name = "Subway",
                    Description ="Restaurant de sandwichs et salades",
                    Addresse ="7 Rue Abou Bakr El Kadiri"
                },
            };

        }

        public List<Restaurant> Restaurants { get; set; }

        public Restaurant addRestaurant(Restaurant restaurant)
        {
            
            Restaurants.Add(restaurant);
            return restaurant;
        }

        public Restaurant deleteRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> getAllRestaurants()
        {
            return Restaurants;
        }

        public Restaurant updateRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }
        public Restaurant getRestaurantById(int id)
        {
            return Restaurants.SingleOrDefault(x => x.Id == id);
        }
    }
}
