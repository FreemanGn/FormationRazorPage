using Formation_Web_ASP.NET_Core.Models;

namespace Formation_Web_ASP.NET_Core.Services
{
    public interface IRestaurantService
    {
      
        public List<Restaurant> getAllRestaurants();
        public Restaurant getRestaurantById(int id);

        public Restaurant addRestaurant(Restaurant restaurant);
        public Restaurant deleteRestaurant(Restaurant restaurant);
        public Restaurant updateRestaurant(Restaurant restaurant);
    }
}
