using Microsoft.EntityFrameworkCore;
using MC_FinalProject.Models;

namespace MC_FinalProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ModProject> ModProjects { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<GameVersion> GameVersions { get; set; }
    }
}
