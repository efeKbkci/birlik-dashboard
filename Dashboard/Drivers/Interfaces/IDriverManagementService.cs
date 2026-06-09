using Birlik.Shared.DTOs.Page;
using Birlik.Shared.Enums;
using System.Threading.Tasks;

namespace Dashboard.Drivers.Interfaces
{
    public interface IDriverManagementService
    {
        Task<DriverManagementPageDto> GetPageDataAsync(int companyId);
        Task CreateDriver(Birlik.Shared.DTOs.DriverCreateDto dto);
        Task UpdateDriverStatusAsync(int driverId, DriverStatus driverStatus);
    }
}