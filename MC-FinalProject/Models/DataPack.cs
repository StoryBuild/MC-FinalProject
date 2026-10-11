using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_FinalProject.Models
{
    public class DataPack
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MaxLength(100)]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "Description is required")]
        [MaxLength(500)]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; } = null!;

        public int Downloads { get; set; }

        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = "Download URL is required")]
        [Url(ErrorMessage = "Enter a valid URL")]
        public string DownloadUrl { get; set; } = null!;

        [Required]
        public int DataPackCategoryId { get; set; }
        [ForeignKey(nameof(DataPackCategoryId))]
        public DataPackCategory DataPackCategory { get; set; } = null!;

        [Required]
        public int GameVersionId { get; set; }
        [ForeignKey(nameof(GameVersionId))]
        public GameVersion GameVersion { get; set; } = null!;
    }
}
