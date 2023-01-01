using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace WebProgramlama.Models
{
    public class Component
    {
        [Key]
        public int ComponentId { get; set; }
        [Required]
        Category CategoryName { get; set; }

        public string Name { get; set; }
        public float? Voltage { get; set; }
        public string Description { get; set; }
        public List<string> Projects { get; set; }
        public string? LinkDatasheet { get; set; }

    }
}
