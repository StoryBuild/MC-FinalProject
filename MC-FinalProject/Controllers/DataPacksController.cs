using MC_FinalProject.Data;
using MC_FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MC_FinalProject.Controllers
{
    public class DataPacksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DataPacksController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var packs = await _context.DataPacks
                .Include(d => d.DataPackCategory)
                .Include(d => d.GameVersion)
                .ToListAsync();

            return View(packs);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var pack = await _context.DataPacks
                .Include(d => d.DataPackCategory)
                .Include(d => d.GameVersion)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (pack == null) return NotFound();

            return View(pack);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _context.DataPackCategories.ToList();
            ViewBag.GameVersions = _context.GameVersions.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DataPack dataPack)
        {
            ModelState.Remove("DataPackCategory");
            ModelState.Remove("GameVersion");

            if (ModelState.IsValid)
            {
                _context.Add(dataPack);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categories = _context.DataPackCategories.ToList();
            ViewBag.GameVersions = _context.GameVersions.ToList();
            return View(dataPack);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var pack = await _context.DataPacks.FindAsync(id);
            if (pack == null) return NotFound();

            ViewBag.Categories = _context.DataPackCategories.ToList();
            ViewBag.GameVersions = _context.GameVersions.ToList();
            return View(pack);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, DataPack dataPack)
        {
            if (id != dataPack.Id) return NotFound();

            ModelState.Remove("DataPackCategory");
            ModelState.Remove("GameVersion");

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dataPack);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DataPackExists(dataPack.Id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categories = _context.DataPackCategories.ToList();
            ViewBag.GameVersions = _context.GameVersions.ToList();
            return View(dataPack);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var pack = await _context.DataPacks
                .Include(d => d.DataPackCategory)
                .Include(d => d.GameVersion)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (pack == null) return NotFound();

            return View(pack);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pack = await _context.DataPacks.FindAsync(id);
            if (pack != null)
            {
                _context.DataPacks.Remove(pack);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DataPackExists(int id)
        {
            return _context.DataPacks.Any(e => e.Id == id);
        }
    }
}
