using marketWebSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace marketWebSite.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index() //contacts
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Contact contact) 
        {
            if(ModelState.IsValid) {
                return Redirect("/");
            }
            return View("Index");
        }
    }
}
