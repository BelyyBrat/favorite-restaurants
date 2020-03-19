using System.Collections.Generic;

namespace FavoriteRestaurants.Models
{
  public class Restaurant
  {

    public Restaurant()
    {
      this.Reviews = new HashSet<Review>();
    }
    public int RestaurantId { get; set; }
    public string Name {get; set;}
    public string Description { get; set; }
    // public Dictionary <int, string> PriceLevel {get; set;}
    public string PriceLevel { get; set; }
    public string Rating { get; set; }
    public string Type {get; set;}

    public bool Vegetarian { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
    
  }
  public enum PriceLevel
  {
    Cheap,
    Moderate,
    Expensive
  }

  public enum Rating
  {
    Bad,
    NotBad,
    Average,
    Good,
    Perfect
  }  
}