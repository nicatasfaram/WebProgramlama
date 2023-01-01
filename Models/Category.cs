using System.ComponentModel.DataAnnotations;

namespace WebProgramlama.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
