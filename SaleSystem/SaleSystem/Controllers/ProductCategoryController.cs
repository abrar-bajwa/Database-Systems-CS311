using Microsoft.AspNetCore.Mvc;
using SaleSystem.Data;
using SaleSystem.Models;

namespace SaleSystem.Controllers
{
    public class ProductCategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ProductCategory> ProductCategory = _db.ProductCategory.ToList();
            return View(ProductCategory);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductCategory obj)
        {
            if (ModelState.IsValid)
            {
                _db.ProductCategory.Add(obj);
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
            var ProductCategory = _db.ProductCategory.Find(id);
            if (ProductCategory == null)
            {
                return NotFound();
            }
            return View(ProductCategory);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ProductCategory obj)
        {

            if (ModelState.IsValid)
            {
                _db.ProductCategory.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.ProductCategory.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.ProductCategory.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
