using Microsoft.AspNetCore.Mvc;
using SafeTradeHtml.Models;
using System.Diagnostics;

namespace SafeTradeHtml.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route(""),Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("our-services")]
        public IActionResult Service()
        {
            return View();
        }
        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [Route("about-us")]
        public IActionResult AboutUs()
        {
            return View();
        }
        [Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
        [Route("masthead")]
        public IActionResult Masthead()
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