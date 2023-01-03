using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
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
        [Required, Display(Name = "Link DataSheet")]
        public string LinkDatasheet { get; set; }
        public int CategoryId { get; set; }
        [DataType(DataType.ImageUrl), Display (Name = "Picture")]
        public string PictureUrl { get; set; }
        [ValidateNever]
        public Category Category { get; set; }

        [ValidateNever]
        public int LikeCount { get; set; }

        [ValidateNever]
        public int CommentCount { get; set; }
        [ValidateNever]
        public ICollection<Comment> Comments { get; set; }

    }
}
