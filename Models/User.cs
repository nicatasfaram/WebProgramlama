using Microsoft.AspNetCore.Identity;

namespace WebProgramlama.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DOB { get; set; }
        public byte[]? ProfilePicture { get; set; }

    }

}
