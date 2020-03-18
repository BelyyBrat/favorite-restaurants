namespace FavoriteRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name {get; set;}
    public string Description { get; set; }
    public int PriceLevel {get; set;}
    public int Rating { get; set; }
    public string Type {get; set;}
    public bool Vegetarian { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
  }
}