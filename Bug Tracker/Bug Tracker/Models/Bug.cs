

using System.ComponentModel.DataAnnotations;

namespace Bug_Tracker.Models
{
    public class Bug
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public Project Project { get; set; }
    }
}
