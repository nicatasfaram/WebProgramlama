using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace WebProgramlama.Models
{
    public class Component
    {
        [Key]
        public int ComponentId { get; set; }
        [Required]
        public string Name { get; set; }
        public float Voltage { get; set; }
        public string Description { get; set; }
        public string LinkDatasheet { get; set; }

        public int CategoryId { get; set; }

    }
}
