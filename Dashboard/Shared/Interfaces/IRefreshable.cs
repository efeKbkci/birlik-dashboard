using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Shared.Interfaces
{
    // MainForm her ShowPage metodunu çağırdığında IRefreshable arayüze sahip sınıfın içerisindeki veriler yenilenecek. 
    public interface IRefreshable
    {
        Task RefreshDataAsync();
    }
}
