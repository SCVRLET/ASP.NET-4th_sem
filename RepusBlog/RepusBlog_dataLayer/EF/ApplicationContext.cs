using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using RepusBlog_dataLayer.Entities;

namespace RepusBlog_dataLayer.EF
{
    public class ApplicationContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(string conectionString) : base(conectionString) { }

        public DbSet<ClientProfile> ClientProfiles { get; set; }
    }
}
