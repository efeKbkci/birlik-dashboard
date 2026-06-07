using Birlik.Shared.DTOs.Page;
using System.Threading.Tasks;

namespace Dashboard.Stops.Interfaces
{
    public interface IStopManagementService
    {
        Task<StopManagementPageDto> GetPageDataAsync(int companyId);
    }
}