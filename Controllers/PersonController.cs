using Microsoft.AspNetCore.Mvc;
using NetMVC.Models;
namespace NetMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strResult = "hello " + ps.PersonID + "-" + ps.FullName;
            ViewBag.thongBao = strResult;
            return View();
        }
    }
}