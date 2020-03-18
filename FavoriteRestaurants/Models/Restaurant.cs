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

  public enum PriceLevel
  {
    Cheap = 1,
    Moderate = 2,
    Expensive = 3
  }

  public enum Rating
  {
    Bad = 1,
    NotBad = 2,
    Average = 3,
    Good = 4,
    Perfect = 5
  }  
}