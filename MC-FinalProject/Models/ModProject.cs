using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_FinalProject.Models
{
    public class ModProject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = null!;

        [Required]
        public string Author { get; set; } = null!;

        public int Downloads { get; set; }

        public string? ImageUrl { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public int GameVersionId { get; set; }
        [ForeignKey(nameof(GameVersionId))]
        public GameVersion GameVersion { get; set; } = null!;

        [Required(ErrorMessage = "Линкът за изтегляне е задължителен")]
        [Url(ErrorMessage = "Въведете валиден URL адрес (напр. https://curseforge.com/...)")]
        public string DownloadUrl { get; set; } = null!;

        [Required(ErrorMessage = "Изберете среда (Client/Server/Both)")]
        [MaxLength(20)]
        public string Environment { get; set; } = null!;

        [Required]
        public int ModLoaderId { get; set; }
        [ForeignKey(nameof(ModLoaderId))]
        public ModLoader ModLoader { get; set; } = null!;
    }
}
