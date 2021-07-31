
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bug_Tracker.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Bug> Bugs { get; set; }
    }
}
