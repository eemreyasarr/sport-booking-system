using SportBookingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBookingSystem.Domain.Entities
{
    public class BookableResource
    {
        public Guid Id { get; private set; }

        public Guid FacilityId { get; private set; }

        public string Name { get; private set; }

        public ResourceType Type { get; private set; }

        public int Capacity { get; private set; }

        public BookableResource( Guid facilityId, string name, ResourceType type, int capacity)
        {
            Id = Guid.NewGuid();
            FacilityId = facilityId;
            Name = name;
            Type = type;
            Capacity = capacity;
        }
    }
}
