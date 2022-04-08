using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers
{
    public class MoviesController : Controller
    {
        // http:localhost/movies/details/343
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
