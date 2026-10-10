using System.ComponentModel.DataAnnotations;

namespace MC_FinalProject.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        public ICollection<ModProject> ModProjects { get; set; } = new List<ModProject>();
    }
}
