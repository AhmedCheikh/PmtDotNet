using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Wemtek.Domain.Entities
{
    public partial class user : IdentityUser<int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        public int idUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public Nullable<int> UserRole_RoleId { get; set; }
        public Nullable<int> company_Id { get; set; }
        public Nullable<int> templateId_idTemplate { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<user, int> manager)
        {
            // Note the authenticationType must match the one defined in
            // CookieAuthenticationOptions.AuthenticationType 
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here 
            return userIdentity;
        }
    }

    public class CustomRole : IdentityRole<int, CustomUserRole>
    {
        public CustomRole() { }
        public CustomRole(string name) { Name = name; }
    }

    public class CustomUserRole : IdentityUserRole<int>
    {
        public int Id { get; set; }
    }

    public class CustomUserClaim : IdentityUserClaim<int>
    {

    }

    public class CustomUserLogin : IdentityUserLogin<int>
    {
        public int Id { get; set; }
    }
}
