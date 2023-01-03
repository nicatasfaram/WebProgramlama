using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProgramlama.Models
{
    public class Comment
    {
        [Key]
        public int CommmentId { get; set; }
        public int ComponentId { get; set; }

        [Required]
        public string Text { get; set; }

        public string UserName { get; set; }
        [ValidateNever]
        public User User { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreateTime { get; set; }
    }
}