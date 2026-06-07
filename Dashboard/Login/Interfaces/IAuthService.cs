using Dashboard.Login.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Login.Interfaces
{
    public interface IAuthService
    {
        Task<(bool IsSuccess, string ErrorMessage, UserSession UserSession)> LoginAsync(string emailOrPhone, string password);
    }
}
