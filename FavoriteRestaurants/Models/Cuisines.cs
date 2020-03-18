using System.Collections.Generic;

namespace FavoriteRestaurants.Models
{
  public class Cuisine
    {
        public Cuisine()
        {
            this.Restaurants = new HashSet<Restaurant>();
        }

        public int CuisineId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}