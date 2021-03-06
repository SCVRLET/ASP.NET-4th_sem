using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using RepusBlog_businessLayer.DTO;
using RepusBlog_businessLayer.Infrastructure;

namespace RepusBlog_businessLayer.Interfaces
{
    public interface IUserService : IDisposable
    {
        Task<OperationDetails> Create(UserDTO userDto);
        Task<ClaimsIdentity> Authenticate(UserDTO userDto);
        Task SetInitialData(UserDTO adminDto, List<string> roles);
    } 
}
