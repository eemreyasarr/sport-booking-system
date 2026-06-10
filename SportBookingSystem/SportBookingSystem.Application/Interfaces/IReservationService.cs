using SportBookingSystem.Application.DTOs;
using SportBookingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBookingSystem.Application.Interfaces
{
    public interface IReservationService
    {
        Task<ApiResponse<Guid>> CreateReservationAsync(CreateReservationRequest request);
    }
}
