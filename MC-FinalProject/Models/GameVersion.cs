using System.ComponentModel.DataAnnotations;

namespace MC_FinalProject.Models
{
    public class GameVersion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string VersionNumber { get; set; } = null!;

        public ICollection<ModProject> ModProjects { get; set; } = new List<ModProject>();
    }
}
