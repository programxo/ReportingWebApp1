using Microsoft.AspNetCore.Identity;

namespace ReportingWebApp.Models
{
    public class AppUser : IdentityUser
    {
        public Role UserRole { get; set; }
    }

    public enum Role
    {
        Admin,
        Employee
    }
}
