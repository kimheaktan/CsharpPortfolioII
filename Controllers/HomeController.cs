using Microsoft.AspNetCore.Mvc;

namespace PortfolioII.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Home()
        {
            return View();
        }
        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View();
        }
        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View();
        }
    }
}