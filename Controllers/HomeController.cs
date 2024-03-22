using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //int time = DateTime.Now.Hour;
            //NORMAL ŞEKİLDE SAAT BİLGİSİ ALINIR VE DEĞİŞKEN İÇERİSİNE EKLENİR. BU KULLANIMDA İLGİLİ HTML DE model kullanımı yapılır
            //var hello = time > 12 ? "İyi Günler" : "Günaydın";
            //return View(model: hello);

            //ViewBag.Hello = time > 12 ? "İyi Günler" : "Günaydın";
            //ViewBag.Name = "Muhammed";
            //return View();

            //ViewData kullanımı da bu şekilde.
            //ViewData["Hello"] = time > 12 ? "İyi Günler" : "Günaydın";
            //ViewData["Name"] = "Muhammed";
            //return View();
            
            var userCount = Repository.Users.Where(info => info.WillAtend == true).Count();

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Samsun, Kongre Kültür Merkezi",
                Date = new DateTime(2024, 01, 01, 20, 0, 0),
                NumberOfPeople = userCount
            };

            return View(meetingInfo);
        }

    }
}