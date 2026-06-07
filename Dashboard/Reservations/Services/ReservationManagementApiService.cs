using Birlik.Shared.DTOs.Page;
using Dashboard.Reservations.Interfaces;
using Dashboard.Shared.Constants;
using Dashboard.Shared.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Reservations.Services;

public class ReservationManagementApiService : IReservationManagementService
{
    private readonly ApiClient _apiClient = new(ApiEndpoints.BaseUrl);
    public async Task<ReservationManagementPageDto> GetPageDataAsync(int companyId)
    {
        string endpoint = ApiEndpoints.Reservations.GetReservationManagementPage(companyId);
        return await _apiClient.GetAsync<ReservationManagementPageDto>(endpoint);
    }
}
