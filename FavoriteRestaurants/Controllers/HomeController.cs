using Microsoft.AspNetCore.Mvc;

namespace FavoriteRestaurants.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}