using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            // return the empty view
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var isLogedIn = await _accountService.ValidateUser(model.Email, model.Password);
            // create a cookie, userid, email, -> encrypted, expiration time 
            // each and every time you make an http request the cookies are sent to server in http
            // 10:00 authCookie
            // 30 minutes
            // cookie based authetication
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            // call the account service, user repository -> User Table

            var user = await _accountService.RegisterUser(model);
            return RedirectToAction("Login");
        
        }
    }
}
