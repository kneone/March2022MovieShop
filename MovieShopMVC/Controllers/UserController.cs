using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers
{
    public class UserController : Controller
    {
        //show all the movies purchased by currently loged in user
       
        [HttpGet]
        public async Task<IActionResult> Purchases()
        {
            // first whether user is loged in 
            // if the user is not loged in, 
            // redirect to login Page
            // 10:00 AM user email/password => something that can be used at 10:05
            // cookies, authtication cookies that can be used across http request and check whether
            // user is loged in or not.
            // cookies -> location? 
            // 10:05 he/she calls user/purchases
            // look for  the authCookie and look for exp time and get the userid
            // Http Request is independect of each other
            // userid, fo to purchase table and get all the movies purchased
            // display as movie cards, use movie card partial view
            // 
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Favorites()
        {
            return View();
        }
    }
}
