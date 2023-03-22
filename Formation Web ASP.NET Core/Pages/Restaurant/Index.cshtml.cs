using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Formation_Web_ASP.NET_Core.Models;
using Formation_Web_ASP.NET_Core.Services;

namespace Formation_Web_ASP.NET_Core.Pages.Restaurant
{
    public class IndexModel : PageModel
    {
       public  List<Formation_Web_ASP.NET_Core.Models.Restaurant> Restaurants { get; set; }

       

        private readonly IRestaurantService _restaurantService;

        public IndexModel(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        public void OnGet()
        {

            Restaurants = _restaurantService.getAllRestaurants();
        }
    }
}
