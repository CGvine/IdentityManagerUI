using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManagerUI.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public virtual ICollection<IdentityUserRole<Guid>> Roles { get; set; }
        public virtual ICollection<IdentityUserClaim<Guid>> Claims { get; set; }
    }
}
