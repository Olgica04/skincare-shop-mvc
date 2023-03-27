using Application.Dto.Auth;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Application.Services;

namespace skincare_shop_mvc.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAdminService _adminService;

        public AuthController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [HttpGet]
        public IActionResult LogIn()
        {
            bool checkClaim = int.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out int adminId);

            if (!checkClaim)
            {
                return View();
            }

            var admin = _adminService.GetAdmin(adminId);

            if (admin != null)
            {
                return RedirectToAction("Index", "Admin");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginDto loginDto)
        {
            try
            {
                var admin = _adminService.Login(loginDto);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, admin.Username),
                    new Claim(ClaimTypes.NameIdentifier, admin.Id.ToString()),
                    new Claim(ClaimTypes.Role, "Admin")
                };

                var identities = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identities);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "Admin");
            }
            catch (Exception)
            {
                return RedirectToAction("Login");
            }
        }
    }
}