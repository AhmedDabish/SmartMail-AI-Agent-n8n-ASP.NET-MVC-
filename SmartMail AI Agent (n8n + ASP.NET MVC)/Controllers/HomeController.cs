//using System.Diagnostics;
//using Microsoft.AspNetCore.Mvc;
//using SmartMail_AI_Agent__n8n___ASP.NET_MVC_.Models;

//namespace SmartMail_AI_Agent__n8n___ASP.NET_MVC_.Controllers
//{
//    public class HomeController : Controller
//    {
//        private readonly ILogger<HomeController> _logger;

//        public HomeController(ILogger<HomeController> logger)
//        {
//            _logger = logger;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }

//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}

using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(string email)
    {
        using var client = new HttpClient();

        var data = new
        {
            email = email
        };

        var json = JsonSerializer.Serialize(data);

        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await client.PostAsync(
            "http://localhost:5678/webhook/summarize-email",
            content
        );

        var result = await response.Content.ReadAsStringAsync();

        ViewBag.Result = result;

        return View();
    }
}