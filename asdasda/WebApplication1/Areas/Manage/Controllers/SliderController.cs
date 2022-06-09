using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.Utilies;
using WebApplication1.Utilies.Extensions;

namespace WebApplication1.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize]
    public class SliderController : Controller
    {
        private AppDbContext _context { get; }

        public SliderController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Sliders);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Slider slider)
        {
            if (slider.Photo.CheckSize(200))
            {
                TempData["flashType"] = "error";
                TempData["flashMessage"] = "File cant greater than 200kb";
                return View();
            }
            if (!slider.Photo.CheckType("image/"))
            {
                TempData["flashType"] = "error";
                TempData["flashMessage"] = "File must be image";
                return View();
            }
            slider.Image = await slider.Photo.SaveFileAsync(Path.Combine(Constant.ImagePath, "slider"));
            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();
            TempData["flashType"] = "success";
            TempData["flashMessage"] = "Created Succesfuly.";
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Edit(int id)
        {

            Slider slider =  _context.Sliders.Find(id);
            if (slider == null) return NotFound();
            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult>  Edit(Slider slider)
        {
            var ExistDb = _context.Sliders.FirstOrDefault(c => c.Id == slider.Id);
            if (slider.Photo != null) ExistDb.Image = await slider.Photo.SaveFileAsync(Path.Combine(Constant.ImagePath, "slider"));
            if (slider.Title!=null) ExistDb.Title=slider.Title;
            if (slider.Title != null) ExistDb.Description = slider.Description; ;
            await _context.SaveChangesAsync();
            TempData["flashType"] = "success";
            TempData["flashMessage"] = "Succesfuly Edited.";
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var WillDeleted = _context.Sliders.Find(id);
            if (WillDeleted != null)
            {

                TempData["flashType"] = "success";
                TempData["flashMessage"] = "Deleted successfull.";
                _context.Sliders.Remove(WillDeleted);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            TempData["flashType"] = "error";
            TempData["flashMessage"] = "Something went wrong.";
            return RedirectToAction(nameof(Index));
        }
    }
}
