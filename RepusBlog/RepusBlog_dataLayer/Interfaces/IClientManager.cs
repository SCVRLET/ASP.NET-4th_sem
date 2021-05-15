using RepusBlog_dataLayer.Entities;
using System;

namespace RepusBlog_dataLayer.Interfaces
{
    public interface IClientManager:IDisposable
    {
        void Create(ClientProfile item);
    }
}
