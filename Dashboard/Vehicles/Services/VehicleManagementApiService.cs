using Dashboard.Shared.Constants;
using Dashboard.Shared.Http;
using System.Threading.Tasks;
using Dashboard.Vehicles.Interfaces;
using Birlik.Shared.DTOs.Page;

namespace Dashboard.Vehicles.Services
{
    public class VehicleManagementApiService : IVehicleManagementService
    {
        private readonly ApiClient _apiClient = new(ApiEndpoints.BaseUrl);

        public async Task<VehicleManagementPageDto> GetPageDataAsync(int companyId)
        {
            string endpoint = ApiEndpoints.Vehicles.GetVehicleManagementPage(companyId);
            return await _apiClient.GetAsync<VehicleManagementPageDto>(endpoint);
        }
    }
}