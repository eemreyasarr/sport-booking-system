using System;
using System.Collections.Generic;
using System.Text;

namespace SportBookingSystem.Application.DTOs
{
    public class CreateFacilityRequest
    {
        public required string Name { get; set; }
        public string Address { get; set; }
    }
}