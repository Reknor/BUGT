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
        [Required]
        public string Status { get; set; }

        [Required]
        public int ProjectId { get; set; }

        /// <summary>
        /// Project in which bug was reported
        /// </summary>
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }

        public static string[] StatusTypes =
        {
           "reported",
           "in progress",
           "finished"
        };
    }
}
