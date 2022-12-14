using Microsoft.AspNetCore.Mvc;
using music_info_app.Entities;

namespace music_info_appUI.Controllers
{
    public class ArtistController : Controller
    {
        public IActionResult Index(int index)
        {
            var client = new HttpClient();

            var endpoint = new Uri("https://localhost:7166/api/Artists/"+ index.ToString());
            var result = client.GetAsync(endpoint).Result;
            var json = result.Content.ReadAsStringAsync().Result;
            Artist? artist = Newtonsoft.Json.JsonConvert.DeserializeObject<Artist?>(json);
            return View(artist);
        }
    }
}
