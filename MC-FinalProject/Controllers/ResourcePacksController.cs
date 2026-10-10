using MC_FinalProject.Data;
using MC_FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MC_FinalProject.Controllers
{
    public class ResourcePacksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResourcePacksController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var packs = await _context.ResourcePacks
                .Include(r => r.ResourceCategory)
                .Include(r => r.ResourceFeature)
                .Include(r => r.ResourceResolution)
                .Include(r => r.GameVersion)
                .ToListAsync();

            return View(packs);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var pack = await _context.ResourcePacks
                .Include(r => r.ResourceCategory)
                .Include(r => r.ResourceFeature)
                .Include(r => r.ResourceResolution)
                .Include(r => r.GameVersion)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (pack == null) return NotFound();

            return View(pack);
        }

        public IActionResult Create()
        {
            LoadViewBags();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ResourcePack resourcePack)
        {
            ModelState.Remove("ResourceCategory");
            ModelState.Remove("ResourceFeature");
            ModelState.Remove("ResourceResolution");
            ModelState.Remove("GameVersion");

            if (ModelState.IsValid)
            {
                _context.Add(resourcePack);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            LoadViewBags();
            return View(resourcePack);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var pack = await _context.ResourcePacks.FindAsync(id);
            if (pack == null) return NotFound();

            LoadViewBags();
            return View(pack);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ResourcePack resourcePack)
        {
            if (id != resourcePack.Id) return NotFound();

            ModelState.Remove("ResourceCategory");
            ModelState.Remove("ResourceFeature");
            ModelState.Remove("ResourceResolution");
            ModelState.Remove("GameVersion");

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resourcePack);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResourcePackExists(resourcePack.Id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }

            LoadViewBags();
            return View(resourcePack);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var pack = await _context.ResourcePacks
                .Include(r => r.ResourceCategory)
                .Include(r => r.ResourceFeature)
                .Include(r => r.ResourceResolution)
                .Include(r => r.GameVersion)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (pack == null) return NotFound();

            return View(pack);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pack = await _context.ResourcePacks.FindAsync(id);
            if (pack != null)
            {
                _context.ResourcePacks.Remove(pack);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResourcePackExists(int id)
        {
            return _context.ResourcePacks.Any(e => e.Id == id);
        }

        private void LoadViewBags()
        {
            ViewBag.Categories = _context.ResourceCategories.ToList();
            ViewBag.Features = _context.ResourceFeatures.ToList();
            ViewBag.Resolutions = _context.ResourceResolutions.ToList();
            ViewBag.GameVersions = _context.GameVersions.ToList();
        }
    }
}
