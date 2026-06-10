using Microsoft.EntityFrameworkCore;
using SportBookingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBookingSystem.Infrastructure.Contexts
{
    public class SportBookingDbContext : DbContext
    {
        public SportBookingDbContext(
            DbContextOptions<SportBookingDbContext> options)
            : base(options)
        {
        }

        public DbSet<Facility> Facilities => Set<Facility>();

        public DbSet<BookableResource> Resources => Set<BookableResource>();

        public DbSet<Reservation> Reservations => Set<Reservation>();
    }
}
