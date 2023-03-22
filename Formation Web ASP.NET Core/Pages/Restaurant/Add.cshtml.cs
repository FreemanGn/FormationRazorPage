using Formation_Web_ASP.NET_Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation_Web_ASP.NET_Core.Pages.Restaurant
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public Formation_Web_ASP.NET_Core.Models.Restaurant restaurant { get; set; }
        private readonly IRestaurantService _restaurantService;

        public AddModel(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {   
            if(!ModelState.IsValid)
            {
                return Page();
            }
            _restaurantService.addRestaurant(restaurant);
            return RedirectToPage("/Restaurant/Index");
        }

        public IActionResult Delete(int id)
        {
            Formation_Web_ASP.NET_Core.Models.Restaurant restaurant = _restaurantService.getRestaurantById(id);

            _restaurantService.deleteRestaurant(restaurant);
            return RedirectToPage("/Restaurant/index");

        }
    }
}
