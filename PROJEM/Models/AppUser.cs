// AppUser.cs
using Microsoft.AspNetCore.Identity;

namespace PROJEM.Models
{
    public class AppUser: IdentityUser{
        public string? FullName {get; set;} 
    }
    
}
