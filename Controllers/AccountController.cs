using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace cricZee.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserAuthenticationContext _context;
      

        public AccountController(UserAuthenticationContext context)
        {
            _context = context;
           
        }
       
        public IActionResult Login()
        {
            return View();
        }
    
        [HttpPost]
        public IActionResult Login(Sign obj)
        {

            if (!string.IsNullOrEmpty(obj.Uname) && string.IsNullOrEmpty(obj.Upassword))
            {
                return RedirectToAction("Login");
            }
            //Check the user name and password
            //Here can be implemented checking logic from the database
            ClaimsIdentity identity = null;
            bool isAuthenticated = false;

            if ((_context.Signs.SingleOrDefault(e => e.Uname == obj.Uname && e.Upassword == obj.Upassword )) != null && obj.Uname == "admin" )
            {

                //Create the identity for the user
                identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, obj.Uname),
                    new Claim(ClaimTypes.Role, "Admin")
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                isAuthenticated = true;
            }

            if ( _context.Signs.SingleOrDefault(e => e.Uname == obj.Uname && e.Upassword == obj.Upassword) != null)
            {
                //Create the identity for the user
                identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, obj.Uname),
                    new Claim(ClaimTypes.Role, "User")
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                isAuthenticated = true;
            }

            if (isAuthenticated)
            {
                HttpContext.Session.SetString("UserName", obj.UserName);
                var principal = new ClaimsPrincipal(identity);

                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "Home");
            }
            return View();
        }


        public IActionResult Logout()
        {
            
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
               
    }
    
    
}
