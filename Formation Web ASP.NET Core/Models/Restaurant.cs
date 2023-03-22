using System.ComponentModel.DataAnnotations;

namespace Formation_Web_ASP.NET_Core.Models;

public class Restaurant
{
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Description { get; set; }
    
    [Required]
    public string Addresse { get; set; }
}

