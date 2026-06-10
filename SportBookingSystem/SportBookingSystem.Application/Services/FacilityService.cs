using SportBookingSystem.Application.DTOs;
using SportBookingSystem.Application.Interfaces;
using SportBookingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBookingSystem.Application.Services
{
    public class FacilityService : IFacilityService
    {
        private readonly IFacilityRepository _facilityRepository;

        public FacilityService(IFacilityRepository facilityRepository)
        {
            _facilityRepository = facilityRepository;
        }

        public async Task<ApiResponse<Facility>> CreateFacilityAsync(CreateFacilityRequest request)
        {
            var facility = new Facility(
                request.Name,
                request.Address
            );

            await _facilityRepository.AddAsync(facility);

            return new ApiResponse<Facility>
            {
                Success = true,
                StatusCode = 201, // Created
                Message = "Facility created successfully",
                Data = facility,
                Count = 1
            };

        }
    }
}
