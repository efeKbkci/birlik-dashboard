using Birlik.Shared.DTOs.Page;
using System.Threading.Tasks;

namespace Dashboard.Vehicles.Interfaces
{
    public interface IVehicleManagementService
    {
        Task<VehicleManagementPageDto> GetPageDataAsync(int companyId);
    }
}