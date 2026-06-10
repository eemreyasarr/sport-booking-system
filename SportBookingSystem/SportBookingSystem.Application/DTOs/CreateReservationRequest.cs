using System;
using System.Collections.Generic;
using System.Text;

namespace SportBookingSystem.Application.DTOs
{
    public class CreateReservationRequest
    {
        public Guid ResourceId { get; set; }

        public string UserEmail { get; set; } = string.Empty;

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }
    }
}
