using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    public class ApplicationUserClaim : IdentityUserClaim<string>
    {
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}