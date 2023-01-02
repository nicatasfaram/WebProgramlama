using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace WebProgramlama.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Component>? Components { get; set; }
    }
}
