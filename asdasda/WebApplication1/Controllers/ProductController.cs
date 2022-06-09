using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {

            private AppDbContext _context { get; }

            public ProductController(AppDbContext context)
            {
                _context = context;
            }

            public IActionResult Index()
            {
                ViewBag.ProductCount = _context.Products.Where(p => p.IsDeleted == false).Count();
                ViewBag.Categories = _context.Categories.Where(p => p.IsDeleted == false).Include(c => c.Products);
                return View(_context.Products.Where(p => p.IsDeleted == false).OrderByDescending(p => p.Id).Take(10).Include(p => p.ProdutcImages).Include(p => p.Category));
            }
            public IActionResult LoadMore(int skip)
            {

                IQueryable<Product> p = _context.Products.Where(p => p.IsDeleted == false);
                int productCount = p.Count();
                if (productCount <= skip)
                {
                    return Json(new
                    {
                    });
                }
                return PartialView("_ProductParial", p
                                        .OrderByDescending(p => p.Id)
                                        .Skip(skip)
                                        .Take(10)
                                        .Include(p => p.ProdutcImages)
                                        .Include(p => p.Category));

            }
            public IActionResult CategoryFilter(int CategoryId)
            {
                if (_context.Categories.Find(CategoryId) == null) return NotFound();
                return PartialView("_ProductParial", _context.Products.Where(p => p.IsDeleted == false && p.CategoryId == CategoryId)
                                    .OrderByDescending(p => p.Id)
                                    .Include(p => p.ProdutcImages)
                                    .Include(p => p.Category));
            }
        public IActionResult Cart()
        {
            List<BasketVm> basket = GetBasket();
            List<BasketItemVM> basketItems = new List<BasketItemVM>();
            foreach (var item in basket)
            {
                Product dbProduct = _context.Products.Include(p => p.ProdutcImages).FirstOrDefault(p => p.Id == item.ProductId);
                if (dbProduct == null) continue;
                BasketItemVM basketItem = new BasketItemVM
                {
                    ProductId = dbProduct.Id,
                    Image = dbProduct.ProdutcImages.FirstOrDefault(pi => pi.IsFront).Image,
                    Name = dbProduct.Name,
                    Price = dbProduct.Price,
                    Raiting = (float)dbProduct.Rating,
                    IsActive = dbProduct.StockCount > 0 ? true : false,
                    Count = item.Count
                };
                basketItems.Add(basketItem);
            }
            return View(basketItems);
        }
        public IActionResult Basket()
        {
            List<BasketVm> product = JsonConvert.DeserializeObject<List<BasketVm>>(Request.Cookies["Basket"]);
            return Json(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id == null) return BadRequest();
            Product dbProduct = await _context.Products.FindAsync(id);
            if (dbProduct == null) return NotFound();
            UpdateBasket((int)id);
            return RedirectToAction(nameof(Index));
        }

        private List<BasketVm> GetBasket()
        {
            List<BasketVm> basketItems = new List<BasketVm>();
            if (Request.Cookies["Basket"] != null)
            {
                basketItems = JsonConvert.DeserializeObject<List<BasketVm>>(Request.Cookies["Basket"]);
            }
            return basketItems;
        }
        private void UpdateBasket(int id)
        {
            List<BasketVm> basketItems = GetBasket();
            BasketVm basketItem = basketItems.Find(bi => bi.ProductId == id);
            if (basketItem != null)
            {
                basketItem.Count += 1;
            }
            else
            {
                basketItem = new BasketVm
                {
                    ProductId = id,
                    Count = 1
                };
                basketItems.Add(basketItem);
            }
            Response.Cookies.Append("Basket", JsonConvert.SerializeObject(basketItems));
        }
    }
    }


