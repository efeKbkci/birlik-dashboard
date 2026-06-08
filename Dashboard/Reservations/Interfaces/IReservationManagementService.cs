using Birlik.Shared.DTOs;
using Birlik.Shared.DTOs.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Reservations.Interfaces;

public interface IReservationManagementService
{
    Task<ReservationManagementPageDto> GetPageDataAsync(int companyId);
    Task ConfirmReservation(int reservationId);
    Task CancelReservation(int reservationId);
}
