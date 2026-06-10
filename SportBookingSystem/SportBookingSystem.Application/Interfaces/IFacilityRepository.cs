using SportBookingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBookingSystem.Application.Interfaces
{
    public interface IFacilityRepository
    {
        Task AddAsync(Facility facility);
    }
}