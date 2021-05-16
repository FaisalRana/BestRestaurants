using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Cuisine 
  {
    public Cuisine()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }
    public int RestaurantId { get; set; }
    public string Type { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }  
  }
}