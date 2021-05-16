namespace BestRestaurants.Models
{
  public class Restaurant {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string PricePoint { get; set; }
    public string Location { get; set; }
    public virtual Cuisine Cuisine { get; set; }
  }
}