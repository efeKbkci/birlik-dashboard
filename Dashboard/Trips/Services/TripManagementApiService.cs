using Birlik.Shared.DTOs;
using Birlik.Shared.DTOs.Page;
using Dashboard.Shared.Constants;
using Dashboard.Shared.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Trips.Services
{
    public class TripManagementApiService : ITripManagementService
    {
        private readonly ApiClient _apiClient = new(ApiEndpoints.BaseUrl);

        public async Task<TripManagementPageDto> GetPageDataAsync(int companyId)
        {
            string endpoint = ApiEndpoints.Trips.GetTripManagementPage(companyId);
            return await _apiClient.GetAsync<TripManagementPageDto>(endpoint);
        }

        public async Task CreateTrip(TripCreateDto dto)
        {
            string endpoint = ApiEndpoints.Trips.CreateAsync();
            await _apiClient.PostAsync<TripCreateDto, DetailedTripReadDashboardDto>(endpoint, dto);
        }
    }
}
