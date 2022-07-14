using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFDataApp.Models;



namespace EFDataApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Bases.ToListAsync());
        }
        public IActionResult Create()
        {
            //ViewBag.Message = $"Заказ создан его номер{Base.Id}" ;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Base user)
        {
            db.Bases.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
    
}
