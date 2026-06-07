using Dashboard.Login.Core;
using Birlik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Shared
{
    public static class GlobalState
    {
        // Uygulamanın her yerinden aktif şirket bilgisine erişebilmek için oluşturulan sınıf.
        public static UserSession Session { get; set; }
    }
}
