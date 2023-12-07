using Microsoft.AspNetCore.Mvc;

namespace marketWebSite.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index() //contacts
        {
            return View();
        }
    }
}
