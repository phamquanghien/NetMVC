using Microsoft.AspNetCore.Mvc;
using NetMVC.Models;

namespace NetMVC.Controllers
{
    public class PersonController : Controller
    {   
        List<Person> psList = new List<Person>();
        private List<Person> CreatePersonList()
        {
            psList.Add(new Person{PersonID = "PS01", FullName="Nguyen Van A", Address = "Ha Noi"});
            psList.Add(new Person{PersonID = "PS02", FullName="Nguyen Van B", Address = "Ha Noi"});
            psList.Add(new Person{PersonID = "PS03", FullName="Nguyen Van C", Address = "Ha Noi"});
            psList.Add(new Person{PersonID = "PS04", FullName="Nguyen Van D", Address = "Ha Noi"});
            psList.Add(new Person{PersonID = "PS05", FullName="Nguyen Van E", Address = "Ha Noi"});
            psList.Add(new Person{PersonID = "PS06", FullName="Nguyen Van F", Address = "Ha Noi"});
            return  psList;
        }
        //khai bao cac phuong thuc
        public IActionResult Index()
        {
            CreatePersonList();
            return View(psList.ToList());
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            ViewBag.thongBao = ps.PersonID + "-" + ps.FullName + "-" + ps.Address;
            return View();
        }
    }
}