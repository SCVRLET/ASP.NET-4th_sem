using RepusBlog_dataLayer.Identity;
using System;
using System.Threading.Tasks;

namespace RepusBlog_dataLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationUserManager UserManager { get; }
        IClientManager ClientManager { get; }
        ApplicationRoleManager RoleManager { get; }
        Task SaveAsync();
    }
}
