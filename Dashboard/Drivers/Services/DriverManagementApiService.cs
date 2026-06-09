using Birlik.Shared.DTOs;
using Birlik.Shared.DTOs.Page;
using Birlik.Shared.Enums;
using Dashboard.Drivers.Interfaces;
using Dashboard.Shared.Constants;
using Dashboard.Shared.Http;
using System.Threading.Tasks;

namespace Dashboard.Drivers.Services
{
    public class DriverManagementApiService : IDriverManagementService
    {
        private readonly ApiClient _apiClient = new(ApiEndpoints.BaseUrl);

        public async Task<DriverManagementPageDto> GetPageDataAsync(int companyId)
        {
            string endpoint = ApiEndpoints.Drivers.GetDriverManagementPage(companyId);
            return await _apiClient.GetAsync<DriverManagementPageDto>(endpoint);
        }

        public async Task CreateDriver(DriverCreateDto dto)
        {
            string endpoint = ApiEndpoints.Drivers.Create();
            await _apiClient.PostAsync<DriverCreateDto, DetailedDriverReadDto>(endpoint, dto);
        }

        public async Task UpdateDriverStatusAsync(int driverId, DriverStatus driverStatus)
        {
            DriverPatchDto dto = new() { Status = driverStatus };

            string endpoint = ApiEndpoints.Drivers.Patch(driverId);
            await _apiClient.PatchAsync<DriverPatchDto>(endpoint, dto);
        }
    }
}