using Microsoft.AspNetCore.Identity;

namespace MangxahoiBE.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public string Sex { get; set; } = null!;
    }
}