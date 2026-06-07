using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birlik.Shared.Enums
{
    public enum DriverStatus
    {
        Available = 1,  
        OnTrip = 2,       
        OnLeave = 3, // İzinli      
        Unavailable = 4
    }
}
