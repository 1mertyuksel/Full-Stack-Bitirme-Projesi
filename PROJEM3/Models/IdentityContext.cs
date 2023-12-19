using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PROJEM.Models;


namespace PROJEM.Data{

public class IdentityContext : IdentityDbContext<AppUser,AppRole,string>
{
    public IdentityContext(DbContextOptions<IdentityContext> options)
        : base(options)
        
    {
    }

  
}
}