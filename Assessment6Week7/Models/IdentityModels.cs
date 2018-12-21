using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Assessment6Week7.Models
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
        [Display(Name = "First Name")]
        public string FirstName { get; set; } 
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Attendance Date")]
        public DateTime? AttendanceDate { get; set; }
        [Display(Name = "Bringing a guest?")]
        public string Guest1 { get; set; }
        [Display(Name = "Attending?")]
        public string Attending { get; set; }
        [Display(Name = "Guest Name")]
        public string GuestName { get; set; }
        [Display(Name = "Character Name")]
        public string CharacterName { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}