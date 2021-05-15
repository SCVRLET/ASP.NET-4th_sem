using RepusBlog_dataLayer.EF;
using RepusBlog_dataLayer.Entities;
using RepusBlog_dataLayer.Interfaces;

namespace RepusBlog_dataLayer.Repositories
{
    public class ClientManager : IClientManager
    {
        public ApplicationContext Database { get; set; }
        public ClientManager(ApplicationContext db)
        {
            Database = db;
        }

        public void Create(ClientProfile item)
        {
            Database.ClientProfiles.Add(item);
            Database.SaveChanges();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
