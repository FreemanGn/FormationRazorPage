using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation_Web_ASP.NET_Core.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        string stringConnexion = string.Empty;

        public IndexModel(IConfiguration configuration, ILogger<IndexModel> logger)
  
        {
            stringConnexion = configuration["StringConnexion"];
            Console.WriteLine(stringConnexion);

            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}