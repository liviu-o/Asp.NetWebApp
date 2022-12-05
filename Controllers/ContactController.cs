using Microsoft.AspNetCore.Mvc;

namespace Asp.NetEmpty.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}