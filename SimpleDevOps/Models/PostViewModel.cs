using System.ComponentModel.DataAnnotations;

namespace SimpleDevOps.Models
{
    public class PostViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [MaxLength(4000)]
        public string Description { get; set; }

        [Required]
        public string Author { get; set; }
    }
}
