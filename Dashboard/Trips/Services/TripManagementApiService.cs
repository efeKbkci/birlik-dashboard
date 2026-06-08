using Birlik.Shared.DTOs;
using Birlik.Shared.DTOs.Page;
using Birlik.Shared.Enums;
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

        public async Task CreateTripAsync(TripCreateDto dto)
        {
            string endpoint = ApiEndpoints.Trips.Create();
            await _apiClient.PostAsync<TripCreateDto, DetailedTripReadDashboardDto>(endpoint, dto);
        }

        public async Task UpdateTripStatusAsync(int tripId, TripStatus tripStatus)
        {
            TripPatchDto dto = new() { TripStatus = tripStatus };

            string endpoint = ApiEndpoints.Trips.Patch(tripId);
            await _apiClient.PatchAsync<TripPatchDto>(endpoint, dto);
        }
    }
}
