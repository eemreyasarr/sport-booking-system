using SportBookingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBookingSystem.Application.Interfaces
{
    public interface IReservationRepository
    {
        Task<bool> HasOverlappingReservationAsync(Guid resourceId, DateTime startDateTime, DateTime endDateTime);
        Task AddAsync(Reservation reservation);
    }
}
