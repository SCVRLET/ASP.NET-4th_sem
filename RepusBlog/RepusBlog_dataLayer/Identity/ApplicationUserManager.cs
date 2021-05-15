using RepusBlog_dataLayer.Entities;
using Microsoft.AspNet.Identity;

namespace RepusBlog_dataLayer.Identity
{
    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser> store)
                : base(store)
        {
        }
    }
}
