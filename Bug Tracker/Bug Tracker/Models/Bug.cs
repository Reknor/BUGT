using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        /// <summary>
        /// Bug status
        /// | reported
        /// | in progress
        /// | finished
        /// </summary>
        [MaxLength(50)]
        public string Status { get; set; }

        /// <summary>
        /// Project in which bug was reported
        /// </summary>
        public Project Project { get; set; }
    }
}
