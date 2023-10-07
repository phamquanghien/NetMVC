using Microsoft.AspNetCore.Mvc;
using NetMVC.Models;

namespace NetMVC.Controllers
{
    public class StudentController : Controller
    {
        //khai bao cac phuong thuc
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Student std)
        {
            string str = "Hello " + std.StudentID + "-" + std.FullName;
            ViewBag.thongBao = str;
            return View();
        }
    }
}