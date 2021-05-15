using RepusBlog_businessLayer.Interfaces;
using RepusBlog_dataLayer.Repositories;

namespace RepusBlog_businessLayer.Services
{
    public class ServiceCreator : IServiceCreator
    {
        public IUserService CreateUserService(string connection)
        {
            return new UserService(new IdentityUnitOfWork(connection));
        }
    }
}
