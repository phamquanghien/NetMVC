using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetMVC.Data;
using NetMVC.Models;

namespace NetMVC.Controllers
{
    public class PersonController : Controller
    {
        //phuong thuc khoi tao
        private readonly ApplicationDbContext _context;
        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }
        //CRUD
        public async Task<IActionResult> Index()
        {
            var model = await _context.Person.ToListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Person ps)
        {
            if(ModelState.IsValid)
            {
                _context.Person.AddAsync(ps);
                _context.SaveChangesAsync();
                //neu tao moi du lieu thanh cong
                return RedirectToAction(nameof(Index));
            }
            else {
                ModelState.AddModelError("", "du lieu dau vao khong hop le");
            }
            return View(ps);
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}