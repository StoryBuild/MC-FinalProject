using MC_FinalProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MC_FinalProject.Models;

namespace MC_FinalProject.Controllers
{
    public class ModProjectsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ModProjectsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var mods = await _context.ModProjects
                .Include(m => m.Category)
                .Include(m => m.GameVersion)
                .ToListAsync();

            return View(mods);
        }
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.GameVersions = _context.GameVersions.ToList();
            ViewBag.ModLoaders = _context.ModLoaders.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ModProject modProject)
        {
            ModelState.Remove("Category");
            ModelState.Remove("GameVersion");
            ModelState.Remove("ModLoader");

            if (ModelState.IsValid)
            {
                _context.Add(modProject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.GameVersions = _context.GameVersions.ToList();
            ViewBag.ModLoaders = _context.ModLoaders.ToList();

            return View(modProject);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modProject = await _context.ModProjects
                .Include(m => m.Category)
                .Include(m => m.GameVersion)
                .Include(m => m.ModLoader)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (modProject == null)
            {
                return NotFound();
            }

            return View(modProject);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modProject = await _context.ModProjects.FindAsync(id);
            if (modProject == null)
            {
                return NotFound();
            }

            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.GameVersions = _context.GameVersions.ToList();
            ViewBag.ModLoaders = _context.ModLoaders.ToList();
            return View(modProject);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ModProject modProject)
        {
            if (id != modProject.Id)
            {
                return NotFound();
            }

            ModelState.Remove("Category");
            ModelState.Remove("GameVersion");
            ModelState.Remove("ModLoader");

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modProject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModProjectExists(modProject.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.GameVersions = _context.GameVersions.ToList();
            ViewBag.ModLoaders = _context.ModLoaders.ToList();
            return View(modProject);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modProject = await _context.ModProjects
                .Include(m => m.Category)
                .Include(m => m.GameVersion)
                .Include(m => m.ModLoader)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (modProject == null)
            {
                return NotFound();
            }

            return View(modProject);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var modProject = await _context.ModProjects.FindAsync(id);
            if (modProject != null)
            {
                _context.ModProjects.Remove(modProject);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModProjectExists(int id)
        {
            return _context.ModProjects.Any(e => e.Id == id);
        }
    }
}
