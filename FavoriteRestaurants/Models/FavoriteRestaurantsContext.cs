using Microsoft.EntityFrameworkCore;

namespace FavoriteRestaurants.Models
{
  public class FavoriteRestaurantsContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Review> Reviews { get; set; }
    
    public FavoriteRestaurantsContext(DbContextOptions options) : base(options) { }
  }
}