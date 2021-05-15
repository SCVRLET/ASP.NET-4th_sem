using Microsoft.AspNet.Identity.EntityFramework;

namespace RepusBlog_dataLayer.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ClientProfile ClientProfile { get; set; }
    }
}
