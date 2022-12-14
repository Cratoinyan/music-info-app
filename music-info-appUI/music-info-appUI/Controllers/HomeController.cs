using Microsoft.AspNetCore.Mvc;
using music_info_app.Entities;
using music_info_appUI.Models;
using System.Diagnostics;

namespace music_info_appUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var client = new HttpClient();

            var endpoint = new Uri("https://localhost:7166/api/Artists");
            var result = client.GetAsync(endpoint).Result;
            var json = result.Content.ReadAsStringAsync().Result;
            List<Artist>? artistList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Artist>>(json);

            return View(artistList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}