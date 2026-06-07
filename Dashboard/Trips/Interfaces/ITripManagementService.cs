using Birlik.Shared.DTOs;
using Birlik.Shared.DTOs.Page;
using Dashboard.Shared.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Trips.Services
{
    public interface ITripManagementService
    {
        Task<TripManagementPageDto> GetPageDataAsync(int companyId);
        Task CreateTrip(TripCreateDto dto);
    }
}
