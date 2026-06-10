using Microsoft.EntityFrameworkCore;
using SportBookingSystem.Application.Interfaces;
using SportBookingSystem.Domain.Entities;
using SportBookingSystem.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBookingSystem.Infrastructure.Repositories
{
    public class FacilityRepository : IFacilityRepository
    {
        private readonly SportBookingDbContext _context;

        public FacilityRepository(SportBookingDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Facility facility)
        {
            await _context.Facility.AddAsync(facility);
            await _context.SaveChangesAsync();
        }
    }
}
