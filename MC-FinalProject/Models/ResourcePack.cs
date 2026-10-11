using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_FinalProject.Models
{
    public class ResourcePack
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
        public int ResourceCategoryId { get; set; }
        [ForeignKey(nameof(ResourceCategoryId))]
        public ResourceCategory ResourceCategory { get; set; } = null!;

        [Required]
        public int ResourceFeatureId { get; set; }
        [ForeignKey(nameof(ResourceFeatureId))]
        public ResourceFeature ResourceFeature { get; set; } = null!;

        [Required]
        public int ResourceResolutionId { get; set; }
        [ForeignKey(nameof(ResourceResolutionId))]
        public ResourceResolution ResourceResolution { get; set; } = null!;

        [Required]
        public int GameVersionId { get; set; }
        [ForeignKey(nameof(GameVersionId))]
        public GameVersion GameVersion { get; set; } = null!;
    }
}
