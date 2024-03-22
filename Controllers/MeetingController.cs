using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        public IActionResult Apply()
        {
            return View();
        }

        //Gelecek olan request isteğinin http verbs karşılığı. Aynı isimde olursa içerisine parametre vermek gerekiyor
        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            if (ModelState.IsValid)
            {
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(info => info.WillAtend == true).Count();
                return View("Thanks", model);
            }
            else
            {
                return View(model);
            }

        }
        public IActionResult List()
        {
            return View(Repository.Users);
        }
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
    }
}