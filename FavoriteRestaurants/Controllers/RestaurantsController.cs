using Microsoft.AspNetCore.Mvc;
using FavoriteRestaurants.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FavoriteRestaurants.Controllers
{
  public class RestaurantsController : Controller
  {
    private readonly FavoriteRestaurantsContext _db;

    public RestaurantsController(FavoriteRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Restaurant> model = _db.Restaurants.Include(restaurants => restaurants.Cuisine).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Type");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
      return View(thisRestaurant);
    }

    public ActionResult Edit(int id)
    {
      var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Type");
      return View(thisRestaurant);
    }

    [HttpPost]
    public ActionResult Edit(Restaurant restaurant)
    {
      _db.Entry(restaurant).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      return View(thisRestaurant);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      _db.Restaurants.Remove(thisRestaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    
    public ActionResult Search()
    {
      return View();
    }

    [HttpPost]
    public ActionResult SearchResults(Restaurant searchRestaurant)
    {
      string searchCriteria = searchRestaurant.Name.ToLower();
      List<Restaurant> allModels = _db.Restaurants.ToList();
      List<Restaurant> foundModels = new List <Restaurant>{};
      
      if (searchRestaurant.Description == "Name")
      {
        foundModels = allModels.FindAll(x => x.Name.ToLower().Contains(searchCriteria) == true);
      }
      else if (searchRestaurant.Description == "PriceLevel")
      {
        foundModels = allModels.FindAll(x => x.PriceLevel.ToLower() == searchCriteria);
      }
      else if (searchRestaurant.Description == "Rating")
      {
        foundModels = allModels.FindAll(x => x.Rating.ToLower() == searchCriteria);
      }
      else if (searchRestaurant.Description == "Type")
      {
        foundModels = allModels.FindAll(x => x.Type.ToLower() == searchCriteria);
      }
      else if (searchRestaurant.Vegetarian == true)
      {
        foundModels = allModels.FindAll(x => x.Vegetarian == true);
      }   
      return View(foundModels);  
    }
  }
}