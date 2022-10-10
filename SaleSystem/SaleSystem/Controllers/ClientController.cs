using Microsoft.AspNetCore.Mvc;
using SaleSystem.Data;
using SaleSystem.Models;

namespace SaleSystem.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ClientController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Client> Clients = _db.Client.ToList();
            return View(Clients);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Client obj)
        {
            if (ModelState.IsValid)
            {
                _db.Client.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var Client = _db.Client.Find(id);
            if (Client == null)
            {
                return NotFound();
            }
            return View(Client);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Client obj)
        {

            if (ModelState.IsValid)
            {
                _db.Client.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Client.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Client.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
