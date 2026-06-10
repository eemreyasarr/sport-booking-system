using SportBookingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBookingSystem.Domain.Entities
{
    public class Reservation
    {
        public Guid Id { get; private set; }

        public Guid ResourceId { get; private set; }

        public string UserEmail { get; private set; }

        public DateTime StartDateTime { get; private set; }

        public DateTime EndDateTime { get; private set; }

        public ReservationStatus Status { get; private set; }

        private Reservation()
        {
        }

        public Reservation( Guid resourceId, string userEmail, DateTime start, DateTime end)
        {
            Id = Guid.NewGuid();
            ResourceId = resourceId;
            UserEmail = userEmail;
            StartDateTime = start;
            EndDateTime = end;
            Status = ReservationStatus.Confirmed;
        }
    }
}
