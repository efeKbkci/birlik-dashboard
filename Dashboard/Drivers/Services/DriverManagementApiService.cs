using Dashboard.Shared.Constants;
using Dashboard.Shared.Http;
using System.Threading.Tasks;
using Dashboard.Drivers.Interfaces;
using Birlik.Shared.DTOs.Page;
using Birlik.Shared.DTOs;

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
            string endpoint = ApiEndpoints.Drivers.CreateAsync();
            await _apiClient.PostAsync<DriverCreateDto, DetailedDriverReadDto>(endpoint, dto);
        }
    }
}