using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Areas.Manage.Controllers
{
        [Area("Manage")]
        [Authorize]
    public class CategoryController : Controller
    {
        public AppDbContext _context { get; }

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {
            List<Category> Categories = await _context.Categories.ToListAsync();
            return View(Categories);
        }
        public  IActionResult Create( )
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Category Categories)
        {
            if (_context.Categories.FirstOrDefault(c=>c.Name.ToLower().Trim()== Categories.Name.ToLower().Trim())!=null)
            {
                TempData["flashType"] = "error";
                TempData["flashMessage"] = "Something went wrong.";
                return View();   
            }

            TempData["flashType"] = "success";
            TempData["flashMessage"] = "Category created successfull.";
            
            await _context.AddAsync(Categories);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var WillDeleted= _context.Categories.Find(id);
            if (WillDeleted != null)
            {
                if (WillDeleted.IsDeleted==true)
                {
                _context.Remove(WillDeleted);
                await _context.SaveChangesAsync();
                    TempData["flashType"] = "success";
                    TempData["flashMessage"] = "Deleted Permamently.";
                    return RedirectToAction(nameof(Index));
                }
                WillDeleted.IsDeleted = true;
                TempData["flashType"] = "success";
                TempData["flashMessage"] = "Deleted successfull.";
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            TempData["flashType"] = "error";
            TempData["flashMessage"] = "Something went wrong.";
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            Category category = await _context.Categories.FindAsync(id);
            if (category==null) return NotFound();
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Category category)
        {
            var ExistDb = _context.Categories.FirstOrDefault(c=>c.Id== category.Id);
            if (ExistDb == null) return NotFound();
            ExistDb.Name = category.Name;
            ExistDb.Logo=category.Logo;
            await _context.SaveChangesAsync();
            TempData["flashType"] = "success";
            TempData["flashMessage"] = "Updated successfull.";
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Recovery(int id)
        {
            var WillRecovery = _context.Categories.Find(id);
            if (WillRecovery != null)
            {
                if (WillRecovery.IsDeleted == true)
                {
                    WillRecovery.IsDeleted = false;
                    await _context.SaveChangesAsync();
                    TempData["flashType"] = "success";
                    TempData["flashMessage"] = "Recoveryed Permamently.";
                    return RedirectToAction(nameof(Index));
                }
            }
            TempData["flashType"] = "error";
            TempData["flashMessage"] = "Something went wrong.";
            return RedirectToAction(nameof(Index));
        }

    }
}
