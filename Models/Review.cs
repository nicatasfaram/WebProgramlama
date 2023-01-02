using System.ComponentModel.DataAnnotations;

namespace WebProgramlama.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }




    }
}
