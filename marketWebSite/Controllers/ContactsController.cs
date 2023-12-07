using Microsoft.AspNetCore.Mvc;

namespace marketWebSite.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
