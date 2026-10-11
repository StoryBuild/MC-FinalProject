using System.ComponentModel.DataAnnotations;

namespace MC_FinalProject.Models
{
    public class DataPackCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        public ICollection<DataPack> DataPacks { get; set; } = new List<DataPack>();
    }
}
