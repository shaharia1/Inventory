using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Inventory.Models
{
    //public class ProductDbContext:DbContext
    //{
    //    //public ProductDbContext() : base("ProductDbContext")
    //    //{
    //    //}





    //}

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ProductDbContext : IdentityDbContext<ApplicationUser>
    {
        public ProductDbContext() : base("ProductDbContext", throwIfV1Schema: false)
        {
        }

        public DbSet<Product> Products { get; set; }
        public static ProductDbContext Create()
        {
            return new ProductDbContext();
        }

    }
}