using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.Utilies;
using WebApplication1.Utilies.Extensions;
using WebApplication1.ViewModel;

namespace WebApplication1.Areas.Manage.Controllers
{
        [Area("Manage")]
    [Authorize]
    public class ProductController : Controller
    {
        private AppDbContext _context { get; }
        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> prdcts = await _context.Products.Include(p => p.ProdutcImages).Include(p => p.Category).ToListAsync();
            List<ProductVm> productVMs = new List<ProductVm>();
            foreach (var item in prdcts)
            {
                ProductVm product = new ProductVm
                {
                    Id = item.Id,
                    Name = item.Name,
                    Category = item.Category.Name,
                    Price = item.Price,
                    Image = item.ProdutcImages.FirstOrDefault(pi => pi.IsFront == true).Image,
                    IsDeleted = item.IsDeleted
                };
                productVMs.Add(product);
            }
            return View(productVMs);
        }
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.Where(c => c.IsDeleted == false).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            ViewBag.Categories = _context.Categories.Where(c => c.IsDeleted == false).ToList();
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (_context.Products.Any(p => p.Name.Trim().ToLower() == product.Name.Trim().ToLower()))
            {
                TempData["flashType"] = "error";
                TempData["flashMessage"] = "This Name AlreadyExist";
                return View();
            }
            if (product.Photos != null)
            {
                foreach (var file in product.Photos)
                {
                    ProductImage image = new ProductImage
                    {
                        Image = await file.SaveFileAsync(Path.Combine(Constant.ImagePath, "ProductImages")),
                        IsFront = false,
                        IsBack = false,
                        Product = product
                    };
                    product.ProdutcImages.Add(image);
                }
            }
            product.ProdutcImages = new List<ProductImage>();
            product.ProdutcImages.Add(new ProductImage
            {
                Image = await product.PhotoFront.SaveFileAsync(Path.Combine(Constant.ImagePath, "ProductImages")),
                IsFront = true,
                IsBack = false,
                Product = product
            });
            product.ProdutcImages.Add(new ProductImage
            {
                Image = await product.PhotoBack.SaveFileAsync(Path.Combine(Constant.ImagePath, "ProductImages")),
                IsFront = false,
                IsBack = true,
                Product = product
            });
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            Product product = _context.Products.Find(id);
            if (product == null) return NotFound();
            if (product.IsDeleted == true)
            {
                TempData["flashType"] = "success";
                TempData["flashMessage"] = "Deleted Permamently.";
                _context.Products.Remove(product);
            }
            else
            {
                product.IsDeleted = true;
            }
            _context.SaveChanges();
            TempData["flashType"] = "success";
            TempData["flashMessage"] = "Deleted Succesfuly.";
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int id)
        {
            ViewBag.Categories = _context.Categories.Where(c => c.IsDeleted == false).ToList();
            Product product = _context.Products.Include(p => p.Category).Include(p => p.ProdutcImages).SingleOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Product product)
        {
            var Existdb= _context.Products.Find(id);
            Existdb.Name = product.Name;
            Existdb.Price=product.Price;
            Existdb.PhotoFront=product.PhotoFront;
            return Json(product.PhotoIds);
        }
        private string IsPhotoOk(IFormFile file)
        {
            if (file.CheckSize(500))
            {
                return $"{file.FileName} must be less than 500kb";
            }
            if (!file.CheckType("image/"))
            {
                return $"{file.FileName} is not image";
            }
            return "";
        }


    }
}
