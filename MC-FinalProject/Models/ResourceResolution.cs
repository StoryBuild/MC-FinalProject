using System.ComponentModel.DataAnnotations;

namespace MC_FinalProject.Models
{
    public class ResourceResolution
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; } = null!;

        public ICollection<ResourcePack> ResourcePacks { get; set; } = new List<ResourcePack>();
    }

}
