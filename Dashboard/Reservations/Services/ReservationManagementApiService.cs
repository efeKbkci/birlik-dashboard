using Birlik.Shared.DTOs;
using Birlik.Shared.DTOs.Page;
using Birlik.Shared.Enums;
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

    public async Task CancelReservation(int reservationId)
    {
        var dto = new ReservationPatchDto()
        {
            ReservationStatus = ReservationStatus.Canceled
        };

        await ChangeReservation(reservationId, dto);
    }

    public async Task ConfirmReservation(int reservationId)
    {
        var dto = new ReservationPatchDto()
        {
            ReservationStatus = ReservationStatus.Confirmed
        };

        await ChangeReservation(reservationId, dto);
    }

    private async Task ChangeReservation(int reservationId, ReservationPatchDto patchDto)
    {
        string endpoint = ApiEndpoints.Reservations.Patch(reservationId);
        await _apiClient.PatchAsync<ReservationPatchDto>(endpoint, patchDto);
    }
}
