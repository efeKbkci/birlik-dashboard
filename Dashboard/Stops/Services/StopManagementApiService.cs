using Dashboard.Shared.Constants;
using Dashboard.Shared.Http;
using System.Threading.Tasks;
using Dashboard.Stops.Interfaces;
using Birlik.Shared.DTOs.Page;

namespace Dashboard.Stops.Services
{
    public class StopManagementApiService : IStopManagementService
    {
        private readonly ApiClient _apiClient = new(ApiEndpoints.BaseUrl);

        public async Task<StopManagementPageDto> GetPageDataAsync(int companyId)
        {
            string endpoint = ApiEndpoints.Stops.GetStopManagementPage(companyId);
            return await _apiClient.GetAsync<StopManagementPageDto>(endpoint);
        }
    }
}