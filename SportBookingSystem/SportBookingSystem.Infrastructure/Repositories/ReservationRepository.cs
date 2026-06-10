using Microsoft.EntityFrameworkCore;
using SportBookingSystem.Application.Interfaces;
using SportBookingSystem.Domain.Entities;
using SportBookingSystem.Infrastructure.Contexts;
using SportBookingSystem.Infrastructure.Repositories;

namespace SportBookingSystem.Infrastructure.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly SportBookingDbContext _context;

        public ReservationRepository(SportBookingDbContext context)
        {
            _context = context;
        }

        public async Task<bool> HasOverlappingReservationAsync(Guid resourceId, DateTime startDateTime, DateTime endDateTime)
        {
            return await _context.Reservation.AnyAsync(x =>
                x.ResourceId == resourceId &&
                x.StartDateTime < endDateTime &&
                startDateTime < x.EndDateTime);
        }

        public async Task AddAsync(Reservation reservation)
        {
            await _context.Reservation.AddAsync(reservation);
            await _context.SaveChangesAsync();
        }
    }
}
