using SportBookingSystem.Application.DTOs;
using SportBookingSystem.Application.Interfaces;
using SportBookingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBookingSystem.Application.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<ApiResponse<Reservation>> CreateReservationAsync(CreateReservationRequest request)
        {
            var hasOverlap = await _reservationRepository.HasOverlappingReservationAsync(request.ResourceId, request.StartDateTime, request.EndDateTime);

            if (hasOverlap)
            {
                return new ApiResponse<Reservation>
                {
                    Success = false,
                    StatusCode = 409, // Conflict
                    Message = "Overlapping reservation exists",
                    Data = null
                };
            }

            var reservation = new Reservation(
                request.ResourceId,
                request.UserEmail,
                request.StartDateTime,
                request.EndDateTime);

            await _reservationRepository.AddAsync(reservation);

            return new ApiResponse<Reservation>
            {
                Success = true,
                StatusCode = 200,
                Message = "Reservation created successfully",
                Data = reservation
            };
        }
    }
}
