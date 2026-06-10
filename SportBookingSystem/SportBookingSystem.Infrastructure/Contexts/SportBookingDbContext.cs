using Microsoft.EntityFrameworkCore;
using SportBookingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBookingSystem.Infrastructure.Contexts
{
    public class SportBookingDbContext : DbContext
    {
        public SportBookingDbContext(DbContextOptions<SportBookingDbContext> options): base(options){}

        public DbSet<Facility> Facility => Set<Facility>();

        public DbSet<BookableResource> BookableResource => Set<BookableResource>();
         
        public DbSet<Reservation> Reservation => Set<Reservation>();
    }
}
