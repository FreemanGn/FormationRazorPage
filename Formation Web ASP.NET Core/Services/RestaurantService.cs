using Formation_Web_ASP.NET_Core.Models;
using Formation_Web_ASP.NET_Core.Repositories;
using Formation_Web_ASP.NET_Core.Repository;

namespace Formation_Web_ASP.NET_Core.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository repository;

        public RestaurantService(IRestaurantRepository repository)
        {
            this.repository = repository;
        }

        public Restaurant addRestaurant(Restaurant restaurant)
        {
            restaurant.Id = 0;
            repository.addRestaurant(restaurant);
            return restaurant;
        }

        public Restaurant deleteRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> getAllRestaurants()

        {

          
            return repository.getAllRestaurants();

        }

        public Restaurant getRestaurantById(int id)
        {
           return repository.getRestaurantById(id);
        }

        public Restaurant updateRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
