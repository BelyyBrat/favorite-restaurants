using Microsoft.AspNetCore.Mvc;
using FavoriteRestaurants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FavoriteRestaurants.Controllers
{
  public class ReviewsController : Controller
  {
    private readonly FavoriteRestaurantsContext _db;

    public ReviewsController(FavoriteRestaurantsContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Review> model = _db.Reviews.Include(reviews => reviews.Restaurant).ToList();
      foreach(Review review in model)
      {
        Console.WriteLine(review.ReviewerName);
      }
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.RestaurantId = new SelectList(_db.Restaurants, "RestaurantId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Review review)
    {
      _db.Reviews.Add(review);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // To-Do: Add reviews to restaurant details

  }
}