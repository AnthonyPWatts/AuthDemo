using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AuthDemo.Website.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(127)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(127)")]
        public string LastName { get; set; }
    }
}
