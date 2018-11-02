using Microsoft.AspNetCore.Identity;
using System;

namespace WebApplication1.CustomIdentity
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser<Guid>
    {
    }
}
