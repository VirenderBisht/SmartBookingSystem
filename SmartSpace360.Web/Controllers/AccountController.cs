using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using SmartSpace360.Web.Models;

namespace SmartSpace360.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly HttpClient _httpClient;

        public AccountController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5125"); // API URL
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var jsonContent = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("/api/auth/register", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                TempData["Success"] = "Registration successful.";
                return RedirectToAction("Login");
            }

            ModelState.AddModelError("", "Registration failed. Try again.");
            return View(model);
        }

        public IActionResult Login()
        {
            return View(); // (you can design this next)
        }
    }

}
