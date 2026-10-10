using MC_FinalProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MC_FinalProject.Models;

namespace MC_FinalProject.Controllers
{
    public class ModProjectsController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Dependency Injection на базата данни
        public ModProjectsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /ModProjects/
        // Това е методът, който извлича всички модове и ги праща към изгледа
        public async Task<IActionResult> Index()
        {
            // Извличаме модовете, като включваме и свързаните таблици (Категория и Версия)
            var mods = await _context.ModProjects
                .Include(m => m.Category)
                .Include(m => m.GameVersion)
                .ToListAsync();

            return View(mods);
        }
    }
}
