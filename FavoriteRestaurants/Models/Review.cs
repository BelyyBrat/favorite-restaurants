using System;
using System.Collections.Generic;

namespace FavoriteRestaurants.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string ReviewerName {get; set;}
    public string ReviewRating { get; set; }
    public string Description { get; set; }
    public DateTime ReviewDate { get; set; }
    public int RestaurantId { get; set; }
    public virtual Restaurant Restaurant { get; set; }
  }

  public enum ReviewRating
  {
    Bad = 1,
    NotBad = 2,
    Average = 3,
    Good = 4,
    Perfect = 5
  }

}